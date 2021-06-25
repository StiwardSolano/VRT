using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ColourButton1 : MonoBehaviour
{
    protected GameObject SelectedColour;
    protected OVRInput.Button LButton;
    protected OVRInput.Button RButton;
    public AudioSource ColourName;
    public Material ColourToChange;

    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Hands" || other.gameObject.name == "GrabVolumeBig")
        {
            Debug.Log("Playing sound from: " + gameObject.name);
            ColourName.Play(0);
            ChangeColour();
        }
    }
    void ChangeColour()
    {
        try
        {
            GameObject gm = GameObject.FindWithTag("SwitchColour");
            Debug.Log(GameObject.FindWithTag("SwitchColour"));
            Debug.Log("ChangeColourLog: Object prev tag: " + gm.tag + " " + gm.name);
            gm.GetComponent<Renderer>().material = ColourToChange;
            gm.gameObject.tag = "Untagged";

            gm.transform.position = new Vector3(-22.77f, 7.04f, -2.09f);
            gm.gameObject.tag = "Untagged";
            OVRInput.SetControllerVibration(0.2f, 0.4f, OVRInput.Controller.LTouch);
            OVRInput.SetControllerVibration(0.2f, 0.4f, OVRInput.Controller.RTouch);

            Debug.Log("ChangeColourLog: Object tag: " + gm.tag);
            Debug.Log("ChangeColourLog: Object name: " + gm.name);
        }
        catch (Exception e)
        {
            Debug.LogException(e, this);
        }

    }
}
