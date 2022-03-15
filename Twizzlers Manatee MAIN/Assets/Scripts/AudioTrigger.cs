using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject buttonPlaying;
    public GameObject buttonPlay;

    void Start()
    {
        buttonPlaying.SetActive(false);
    }


    public void PlayAudio()
    {
        audioSource.Play();
        buttonPlaying.SetActive(true);
        buttonPlay.SetActive(false);
    }

}
