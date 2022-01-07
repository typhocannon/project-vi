using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip[] Musics;
    private AudioSource musicSource;


    void Start() {
        musicSource = FindObjectOfType<AudioSource>();
        musicSource.loop = false;
        musicSource.volume = 0.385F;
    }
    
    private AudioClip GetNextSong() {
        return Musics[Random.Range(0, Musics.Length)];
    }

    void Update() {
        if (!musicSource.isPlaying){
                musicSource.clip = GetNextSong();
                musicSource.Play();
            }
        }



}
