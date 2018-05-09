using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class AudioManager : Singleton<AudioManager> {
    [SerializeField]
    private AudioMixer auidoMixer;


    private float musicVolume;
    private float fxVolume;

    protected override void Awake()
    {
        base.Awake();
        musicVolume = 0;
        fxVolume = 0;
        auidoMixer.SetFloat("music", musicVolume);
        auidoMixer.SetFloat("fx", fxVolume);
    }

    public float MusicVolume {
        get { return musicVolume; }
        set {
            musicVolume = value;
            auidoMixer.SetFloat("music", value);
        }

    }
    public float FXVolume
    {
        get { return fxVolume; }
        set
        {
            fxVolume = value;
            auidoMixer.SetFloat("fx", value);
        }

    }
}
