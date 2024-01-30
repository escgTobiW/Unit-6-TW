using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip footstep1;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void PlaySoundEffect()
    {
        audioSource.PlayOneShot(footstep1, 0.7f); // play audio clip with volume 0.7
    }


// Update is called once per frame
void Update()
    {
        
    }
}
