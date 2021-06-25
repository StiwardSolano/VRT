using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SayMeNumber : MonoBehaviour
{
    public AudioSource NumberName;

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Hands" || other.gameObject.name == "GrabVolumeBig")
        {
            Debug.Log("Playing sound from: " + gameObject.name);
            NumberName.Play(0);
        }
    }
}
