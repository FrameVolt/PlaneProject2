using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class AudioManager : PersistentSingleton<AudioManager> {
    [SerializeField]
    private AudioMixer auidoMixer;
    [SerializeField]
    private GameData gameData;

    private float musicVolume;
    private float fxVolume;

    protected override void Awake()
    {
        base.Awake();
        musicVolume = gameData.musicVolume;
        fxVolume = gameData.fxVolume;
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
