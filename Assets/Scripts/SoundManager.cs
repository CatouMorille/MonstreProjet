using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    AudioSource audio;

    void Start(){
        audio = GetComponent<AudioSource>();
    }

    public void PlayEffect(){
        audio.Play();
    }
}
