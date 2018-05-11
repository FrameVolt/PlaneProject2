using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadScene : MonoBehaviour {
    
	void Update () {
        if (Input.GetKeyDown(KeyCode.D)) {

            StartCoroutine(MyLoadScene());
        }
	}

    private IEnumerator MyLoadScene() {
       
        AsyncOperation ao = SceneManager.LoadSceneAsync(0);

        ao.allowSceneActivation = false;
        while (ao.progress < 0.9f) {
            print(ao.progress);
            yield return null;
        }
        ao.allowSceneActivation = true;
    }

}
