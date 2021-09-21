using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volume : MonoBehaviour
{
    private float musicVolume;
    public void setVolume(float vol)
    {

        musicVolume = vol;
        PlayerPrefs.SetFloat("volume", musicVolume);
    }

}
