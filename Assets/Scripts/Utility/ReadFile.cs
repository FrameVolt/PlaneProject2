using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
public class ReadFile : MonoBehaviour {

    public GameData gameData;
    void Start () {
        string s = File.ReadAllText("Assets/TestFile01.txt", System.Text.Encoding.UTF8);

        s = s.Replace("\r", "");
        s = s.Replace("\n", "");
        //gameData = JsonUtility.FromJson<GameData>(s);
        

	}

}
