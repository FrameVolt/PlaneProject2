using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {


    [SerializeField]private CanvasGroup pauseGroup;
    [SerializeField]private CanvasGroup settingGroup;

    private Stack<CanvasGroup> canvasGroupStack = new Stack<CanvasGroup>();
    private List<CanvasGroup> canvasGroupList = new List<CanvasGroup>();


    private void OnEnable()
    {

        if (InputManager.Instance != null)
            InputManager.Instance.OnEsc += Esc;
    }
    private void OnDisable()
    {
        if(InputManager.Instance != null)
        InputManager.Instance.OnEsc -= Esc;
    }


    private void Start()
    {
        canvasGroupList.Add(pauseGroup);
        canvasGroupList.Add(settingGroup);
        DisplayMenu();

    }

    //use Esc return to game or parent menu
    private void Esc() {
        if (canvasGroupStack.Count == 0)
        {
            Pause();
        }
        else {
            if (canvasGroupStack.Count > 0) {
                canvasGroupStack.Pop();
                if (canvasGroupStack.Count == 0) {
                    UnPause();
                }
            }

        }

    }

    public void Pause() {
        GameManager.Instance.Pause();
        canvasGroupStack.Push(pauseGroup);
        DisplayMenu();
    }

    public void UnPause() {
        GameManager.Instance.Pause();
        if (canvasGroupStack.Count > 0) {
            canvasGroupStack.Pop();
        }
        DisplayMenu();

    }
    //go to setting pannel
    public void Setting() {


    }
    //go back main menu
    public void Exit() {
        
    }


    private void DisplayMenu() {
        foreach (var item in canvasGroupList)
        {
            item.alpha = 0;
            item.interactable = false;
            item.blocksRaycasts = false;
        }

        if (canvasGroupStack.Count > 0) {
            CanvasGroup cg = canvasGroupStack.Peek();
            cg.alpha = 1;
            cg.interactable = true;
            cg.blocksRaycasts = true;
        }

    }

}
