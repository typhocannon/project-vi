using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource punch;

    public void PlayPunch() {
        punch.Play();
    }
    
    void OnTriggerEnter() {
        punch.Play();
    }
}
