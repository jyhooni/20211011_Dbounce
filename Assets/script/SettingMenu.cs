using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingMenu : MonoBehaviour
{

    public AudioMixer audioMixer;
    //public GameManager pushFor

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume",volume); 
    }

    public void Setforce(int force)
    {

    }

}
