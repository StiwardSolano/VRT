using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public float maxTimeGrab = 10;
    public Text timerText;
    public AudioSource TimeOver;
    private bool Banderita = false;
    private bool BanderaObjeto = false;
    public GameObject ObjetoaDestruir;
    void Start()
    {
        //timerText.GetComponent<Renderer>().enabled = false;
        timerText.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider collider)
    {
        timerText.text = maxTimeGrab.ToString();
        if (collider.gameObject.tag != "Hands" && collider.gameObject.name != "GrabVolumeBig" && collider.gameObject.name != "GrabVolumeSmall")
        {
            Banderita = true;
            ObjetoaDestruir = collider.gameObject;
            //timerText.GetComponent<Renderer>().enabled = true;
            timerText.gameObject.SetActive(true);
            maxTimeGrab = 10;
            timerText.text = maxTimeGrab.ToString();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Banderita = false;
        //timerText.GetComponent<Renderer>().enabled = false;
        timerText.gameObject.SetActive(false);
        maxTimeGrab = 10;
        //Debug.Log("Thanks for leaving me alone prick!!!! " + maxTimeGrab.ToString());
    }

    private void Update()
    {
        try
        {
            if (Banderita == true && maxTimeGrab > 0.9f)
            {
                maxTimeGrab -= Time.deltaTime;
                timerText.text = maxTimeGrab.ToString();
            }
            else if (maxTimeGrab <= 0.9f)
            {
                BanderaObjeto = true;
            }
            if (BanderaObjeto == true)
            {
                //timerText.GetComponent<Renderer>().enabled = false;
                string texto = " ";
                timerText.text = texto;
                //Debug.Log("Objeto a destruir: " + ObjetoaDestruir.name);
                Destroy(ObjetoaDestruir);
                TimeOver.Play(0);
                maxTimeGrab = 10;
                BanderaObjeto = false;
                Banderita = false;
            }
        }
        catch (Exception e)
        {
            Debug.LogException(e, this);
        }
    }
}
