using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _audioShot; 

    public void PlayShotSound()
    {
        _audioSource.PlayOneShot(_audioShot); 
    }
}
