using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class audio : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioMixer mixer;
    public void SetVolume(){
        mixer.SetFloat("volume", volumeSlider.value);
    }
}
