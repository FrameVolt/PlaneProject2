using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private int damageValue = 100;

    private Vector3 direction = Vector3.up;
	
	
	void Update () {
        transform.Translate(direction * Time.deltaTime * speed);
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<IHealth>() != null) {
            other.GetComponent<IHealth>().Damage(damageValue);
        }
    }

}
