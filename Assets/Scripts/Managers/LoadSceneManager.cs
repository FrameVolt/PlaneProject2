using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneManager {

    public static void LoadScene(string name) {
        LoadScene(SceneUtility.GetBuildIndexByScenePath(name));
    }

    public static void LoadScene(int id)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(id);
    }
}
