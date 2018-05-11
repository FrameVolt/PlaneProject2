using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour {

    [SerializeField]
    private string loadSceneName = "";


    [SerializeField]
    private CanvasGroup buttonGroup;
    [SerializeField]
    private CanvasGroup settingGroup;
    [SerializeField]
    private CanvasGroup creditGroup;


    private Stack<CanvasGroup> canvasGroupStack = new Stack<CanvasGroup>();
    private List<CanvasGroup> canvasGroupList = new List<CanvasGroup>();

    private void OnEnable()
    {

        if (InputManager.Instance != null)
            InputManager.Instance.OnEsc += Esc;
    }
    private void OnDisable()
    {
        if (InputManager.Instance != null)
            InputManager.Instance.OnEsc -= Esc;
    }

    private void Start()
    {
        UIManager.Instance.FadeOn(false);
        canvasGroupList.Add(buttonGroup);
        canvasGroupList.Add(settingGroup);
        canvasGroupList.Add(creditGroup);
        canvasGroupStack.Push(buttonGroup);
        DisplayMenu();
    }

    public void Esc()
    {
        if (canvasGroupStack.Count <= 1) return;
        canvasGroupStack.Pop();
        DisplayMenu();
    }

    public void StartGame() {
        StartCoroutine(LoadGame());
    }

    private IEnumerator LoadGame() {
        UIManager.Instance.FadeOn(true);
        yield return new WaitForSeconds(1);
        LoadSceneManager.LoadScene(loadSceneName);
    }

    public void OptionButton() {
        canvasGroupStack.Push(settingGroup);
        DisplayMenu();
    }
    public void CreditButton() {
        canvasGroupStack.Push(creditGroup);
        DisplayMenu();
    }

    private void DisplayMenu()
    {
        foreach (var item in canvasGroupList)
        {
            item.alpha = 0;
            item.interactable = false;
            item.blocksRaycasts = false;
        }

        if (canvasGroupStack.Count > 0)
        {
            CanvasGroup cg = canvasGroupStack.Peek();
            cg.alpha = 1;
            cg.interactable = true;
            cg.blocksRaycasts = true;
        }


    }
}
