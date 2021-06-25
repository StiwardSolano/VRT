using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectStar : MonoBehaviour
{
    public AudioSource ObjectSound, WrongObjectSound;
    public Material ContainerFull;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "pCylinder1 (1)" || other.gameObject.name == "Star_v1" || other.gameObject.name == "21327_Star_v1")
        {
            ObjectSound.Play(0);
            gameObject.GetComponent<Renderer>().material = ContainerFull;
            Destroy(other.gameObject);
        }
        else
        {
            Debug.Log("This is no Lotso me na fool");
            WrongObjectSound.Play(0);
        }
    }
}
