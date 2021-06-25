using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ColourButton : MonoBehaviour
{
    public GameObject SelectedColour;
    public OVRInput.Button LButton;
    public OVRInput.Button RButton;
    public AudioSource ColourName;
    public string Namae;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("THIS particular script is on " + gameObject.name);
        Debug.Log("Selected Game Object: " + SelectedColour.name);
        Debug.Log("TagName " + Namae.ToString());
        while (Namae.ToString() == SelectedColour.name)
        {
            testu();
        }
        /*SelectedColour = this.gameObject;
        
        ColourName = GetComponent<AudioSource>();
        Debug.Log(ColourName.name);
        ColourName.Play(0);*/
    }

    // Update is called once per frame
    void Update()
    {
        try{
            //Debug.Log(OVRInput.Get(LButton));
            /*
            if (OVRInput.Get(LButton) || OVRInput.Get(RButton))
            {
                OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.LTouch);
                OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.RTouch);
                Debug.Log(ColourName.name);
                ColourName.Play(0);

            } else {
                Debug.Log("Tocame");
            }*/
            

        }
        catch (Exception e)

        {
            Debug.LogException(e, this);
        }
    }

    
    void testu() {
        var ray = Camera.main.ScreenPointToRay(OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch));
        RaycastHit Hit;

        if (OVRInput.Get(LButton) || OVRInput.Get(RButton))
        {
            if (Physics.Raycast(ray, out Hit) && Hit.collider.gameObject == SelectedColour)
            {
                SelectedColour = this.gameObject;
                Debug.Log("Selected Game Object: " + SelectedColour.name);
                Debug.Log("Color: " + ColourName.name);
                ColourName.Play(0);
                OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.RTouch);
                OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.LTouch);
            }
        }
    }

}
