using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundPlay : MonoBehaviour
{
    public GameObject Slider1;
    public GameObject Audio;
    private void Start()
    {
        Audio.SetActive(true);
        Audio.GetComponent<AudioSource>().volume = 0.5f;
        Slider1.GetComponent<Slider>().value = 0.5f;
    }
    public void SetAudioVolume()
    {
        float AudioNum = Slider1.GetComponent<Slider>().value;
        Audio.GetComponent<AudioSource>().volume = AudioNum;
    }
    public void AudioReset()
    {
        Audio.GetComponent<AudioSource>().volume = 0.5f;
        Slider1.GetComponent<Slider>().value = 0.5f;
    }






}

