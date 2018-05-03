using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelfByTime : MonoBehaviour {
    [SerializeField]
    private float time = 5f;
	void Start () {
        Destroy(this.gameObject, time);
	}

}
