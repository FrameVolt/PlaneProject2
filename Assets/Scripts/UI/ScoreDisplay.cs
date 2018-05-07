using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {
    [SerializeField]
    private Text scoreText;

    private Director director;

	void Start () {
        director = Director.Instance;

    }
	
	// Update is called once per frame
	void Update () {
        scoreText.text = director.Score.ToString();
	}
}
