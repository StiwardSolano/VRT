using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundIntro : MonoBehaviour
{
    public AudioSource IntroSound;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        IntroSound.Play(0);
    }
}
