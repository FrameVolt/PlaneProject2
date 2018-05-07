using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {
    [SerializeField]
    private Text scoreText;

    [SerializeField]
    private GameObject[] lifeIcons;

    private Director director;

	void Start () {
        director = Director.Instance;

    }
	
	// Update is called once per frame
	void Update () {
        scoreText.text = director.Score.ToString();
        for (int i = 0; i < lifeIcons.Length; i++)
        {
            lifeIcons[i].SetActive(i < director.PlayerLifeCount);
        }
        


    }
}
