using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class WriteJsonToFile : MonoBehaviour {


    public GameData gameData;

	void Start () {
        //CharacterData characterData = new CharacterData() { name = "lucy", age = 11, isMan = false };

        string myJson = JsonUtility.ToJson(gameData);

        FileStream fs = new FileStream("Assets/TestFile01.txt", FileMode.CreateNew, FileAccess.ReadWrite, FileShare.ReadWrite);
        var bytes = System.Text.Encoding.UTF8.GetBytes(myJson);

        fs.Write(bytes, 0, bytes.Length);
        fs.Close();
    }
	
	
}
