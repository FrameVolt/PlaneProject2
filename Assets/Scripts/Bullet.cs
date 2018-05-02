using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    [SerializeField]
    private float speed = 5f;

    private Vector3 direction = Vector3.up;
	
	
	void Update () {
        transform.Translate(direction * Time.deltaTime * speed);
	}
}
