using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager> {

	public float TimeScale { get; private set; }
    private bool paused;
    public bool Paused { get { return paused; } set { paused = value; } }

    private float savedTimeScale = 1f;

	void Start () {
		
	}
	


    public void Pause() {
        if (Time.timeScale > 0)
        {
            Instance.SetTimeScale(0);
            Instance.Paused = true;
        }
        else {
            UnPause();
        }
    }

    public void UnPause() {
        Instance.ResetTimeScale();
        Instance.Paused = false;
    }

    public void SetTimeScale(float newTimeScale) {
        savedTimeScale = Time.timeScale;
        Time.timeScale = newTimeScale;
    }

    public void ResetTimeScale() {
        Time.timeScale = savedTimeScale;
    }

}
