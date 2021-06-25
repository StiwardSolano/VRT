using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCar : MonoBehaviour
{
    public AudioSource ObjectSound, WrongObjectSound;
    public Material ContainerFull;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "car" || other.gameObject.name ==  "carrus")
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
