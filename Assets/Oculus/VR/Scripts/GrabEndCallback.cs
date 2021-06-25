using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabEndCallback : MonoBehaviour
{
    public AudioSource GrabEndSound;
    public void OnGrabEnd() 
    {
        if (OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, OVRInput.Controller.LTouch) <= 0.6f
        && OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, OVRInput.Controller.LTouch) <= 0.6f)
        {
            //GrabEndSound.PlayDelayed(1);
            GrabEndSound.Play(0);
            //Debug.Log("ME WORKING BITcH!!!!" + GrabEndSound.name);
        }/*else if (OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, OVRInput.Controller.RTouch) <= 0.6f
        && OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, OVRInput.Controller.RTouch) <= 0.6f)
        {
            Debug.Log("Here it me foool!!!!");
        }*/
    }
}
