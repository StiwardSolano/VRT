using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCountDown : MonoBehaviour
{
    private string tagnames;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerStay(Collider other)
    {
        //Debug.Log("Starting to wait??");
        //Debug.Log("Wait finished, starting script");
        tagnames = other.gameObject.tag;
        //Debug.Log("Object on table namae: " + other.gameObject.name);

        try
        {
            while (tagnames == "Untagged")
            {
                other.gameObject.tag = "Counter";
                //Debug.Log("Tag changed, validate: " + other.gameObject.tag);
                //Debug.Log("Object on Table name: " + other.gameObject.name);

                tagnames = "ImaHeadOut";
            }
        }
        catch (Exception e)
        {
            Debug.LogException(e, this);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        other.gameObject.tag = "Untagged";
    }
}
