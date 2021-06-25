using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCube : MonoBehaviour
{
    public AudioSource ObjectSound, WrongObjectSound;
    public Material ContainerFull;
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Cube")
        {
            ObjectSound.Play(0);
            gameObject.GetComponent<Renderer>().material = ContainerFull;
            other.transform.position = new Vector3(-7.8535f, 0.8069f, -6.5739f);
        }
        else
        {
            Debug.Log("This is no Lotso me na fool");
            WrongObjectSound.Play(0);
        }
    }
}
