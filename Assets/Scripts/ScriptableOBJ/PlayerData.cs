using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "GameData", menuName = "Create player data", order = 1)]
public class PlayerData : ScriptableObject
{

    public float hp;
    public float score;
    public Color mainPlaneColor;


}
