using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectObject : MonoBehaviour
{
    private string tagnames;
    private float timer = 0;
    private float timerMax = 0;

    void Start()
    {
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Objeto: " + collision.gameObject.name);
        if (collision.gameObject.tag != "Hands" || collision.gameObject.name != "GrabVolumeBig" || collision.gameObject.name != "GrabVolumeSmall")
        {
            Debug.Log("Collision: " + collision.gameObject.name);

            foreach (ContactPoint contact in collision.contacts)
            {
                print(contact.thisCollider.name + " hit " + contact.otherCollider.name);
                // Visualize the contact point
                if (collision.gameObject.tag != "Hands" || collision.gameObject.name != "GrabVolumeBig" || collision.gameObject.name != "GrabVolumeSmall")
                {
                    tagnames = collision.gameObject.tag;
                    Debug.Log("Objeto en mesa: " + collision.gameObject.name);
                }

                try
                {
                    while (tagnames == "Untagged")
                    {
                        collision.gameObject.tag = "SwitchColour";

                        tagnames = "ImaHeadOut";
                    }
                }
                catch (Exception e)
                {
                    Debug.LogException(e, this);
                }
            }

        }

    }
    
    void OnTriggerStay(Collider other)
    {

        //if (!Waited(1)) return;

        if (other.gameObject.tag != "Hands" || other.gameObject.name != "GrabVolumeBig" || other.gameObject.name != "GrabVolumeSmall")
        {
            tagnames = other.gameObject.tag;
            Debug.Log("Objeto en mesa: " + other.gameObject.name);
        }

        try
        {
            while (tagnames == "Untagged")
            {
                other.gameObject.tag = "SwitchColour";

                tagnames = "ImaHeadOut";
            }
        }
        catch (Exception e)
        {
            Debug.LogException(e, this);
        }

    }

    private bool Waited(float seconds)
    {
        timerMax = seconds;
        timer += Time.deltaTime;

        if (timer >= timerMax)
        {
            return true; //max reached - waited x - seconds
        }
        return false;
    }

    
    void Update()
    {
        
    }
}
