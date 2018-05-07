using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class AudioManager : MonoBehaviour {
    [SerializeField]
    private AudioMixer auidoMixer;


	void Start () {
        auidoMixer.SetFloat("fx",-20);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
