using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicateTest : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject rosen;
    void Start()
    {
        rosen = GameObject.Find("Rosen");
        rosen.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag != "Hands" || other.gameObject.name != "GrabVolumeBig" || other.gameObject.name != "GrabVolumeSmall")
        {/*
            for (int i = 0; i < 5; i++)
            {
                Instantiate(other.gameObject);
            }*/
            rosen.SetActive(true);
        }

    }
    void Update()
    {
        
    }
}
