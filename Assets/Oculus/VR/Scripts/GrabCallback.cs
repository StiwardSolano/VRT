using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrabCallback : MonoBehaviour
{
    public AudioSource PickUpObjectSound; 
    public int maxTimeGrab = 10;
    public Text timerText;
    public void OnGrab() {

        PickUpObjectSound.Play(0);
        getCollider(gameObject.GetComponent<Collider>());

        //CountDownTester
        void getCollider(Collider collider){

            if(collider.gameObject.tag == "CountDown"){
                timerText.text = maxTimeGrab.ToString();
                maxTimeGrab--;
            }
        }
        
        if (OVRInput.Get(OVRInput.Button.Three) && OVRInput.Get(OVRInput.Button.One))
        {
            gameObject.transform.localScale += new Vector3(0.159f, 0.159f, 0.159f);
        }
        else
        {//ButtonFour = Y, ButtonTwo = B
            if (OVRInput.Get(OVRInput.Button.Four) && OVRInput.Get(OVRInput.Button.Two))
            {
                gameObject.transform.localScale -= new Vector3(0.159f, 0.159f, 0.159f);
            }
        }
        if (OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, OVRInput.Controller.LTouch) == 0.0f
            && OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, OVRInput.Controller.LTouch) == 0.0f)/*
            || OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, OVRInput.Controller.RTouch) == 0.0f
            && OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, OVRInput.Controller.RTouch) == 0.0f)*/
        {
            Debug.Log("On grab end, AM I WORKING LTOUCH???????" + OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, OVRInput.Controller.LTouch));
        }
    }
}
