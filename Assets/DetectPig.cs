using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPig : MonoBehaviour
{
    public AudioSource ObjectSound, WrongObjectSound;
    public Material ContainerFull;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "hamm_high_0")
        {
            ObjectSound.Play(0);
            gameObject.GetComponent<Renderer>().material = ContainerFull;
        }
        else
        {
            Debug.Log("This is no Lotso me na fool");
            WrongObjectSound.Play(0);
        }
    }
}
