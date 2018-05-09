using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingPannel : MonoBehaviour {

    [SerializeField]
    private Slider musicSlider;
    [SerializeField]
    private Slider effectSlider;


    private void Start()
    {
        musicSlider.value = AudioManager.Instance.MusicVolume;
        effectSlider.value = AudioManager.Instance.FXVolume;
    }

    public void OnMusicSilder(float volume) {
        AudioManager.Instance.MusicVolume = volume;
    }
    public void OnEffectSilder(float volume)
    {
        AudioManager.Instance.FXVolume = volume;
    }
}
