using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {


    private Collider2D coll;
    private Renderer rend;
    private AudioSource coinAudio;

	void Awake () {
        coll = GetComponent<Collider2D>();
        rend = GetComponent<Renderer>();
        coinAudio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            coll.enabled = false;
            Director.Instance.Score += 10;
            rend.enabled = false;
            coinAudio.Play();
            Destroy(this.gameObject, coinAudio.clip.length);
        }
    }
}
