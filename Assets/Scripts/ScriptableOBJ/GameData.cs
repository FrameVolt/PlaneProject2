using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "GameData",menuName = "Create game data",order = 0)]
[Serializable]
public class GameData : ScriptableObject {

    public float musicVolume;
    public float fxVolume;
    public PlayerData playerData;


}
