using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagnetScript : MonoBehaviour
{
    public int operador1, operador2, resultado;
    //public Text ResultText;
    public GameObject Respuesta, Siguiente, localSum;
    public AudioSource Correcto;
    private int resultadoTemp, operador1temp, operador2temp;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Objeto: " + collision.gameObject.name);
        //int resultadoTemp, operador1temp, operador2temp;
        foreach (ContactPoint contact in collision.contacts)
        {
            print(contact.thisCollider.name + " hit " + contact.otherCollider.name);
            // Visualize the contact point
            if(Int32.Parse(contact.otherCollider.name) == operador1)//contact.otherCollider.name == "4"
            {
                operador1temp = Int32.Parse(contact.otherCollider.name);
            }
            else if (Int32.Parse(contact.otherCollider.name) == operador2)//contact.otherCollider.name == "2"
            {
                operador2temp = Int32.Parse(contact.otherCollider.name);
            }
            resultadoTemp = operador1temp + operador2temp;
            //ResultText.text = resultado.ToString();//(?
            //GameObject gm = GameObject.Find("suma");
            if (resultadoTemp == resultado)//resultado == 6
            {
                Respuesta.SetActive(true);
                //sonido
                Correcto.PlayDelayed(2);
                Invoke("ChangeSum", 5);
            }
            /*if (resultado == 6 && banderita == true)
            {
                gm.SetActive(false);
            }*/
            /*
            Rigidbody rBody = GetComponent<Rigidbody>();
            rBody.isKinematic = false;
            rBody.detectCollisions = true;*/
            //Debug.Log("Resultado = " + resultado);
        }

    }
    void ChangeSum()
    {
        Debug.Log("Activando la siguiente suma");
        localSum.SetActive(false);
        try
        {
            Siguiente.SetActive(true);
        }
        catch (Exception e)
        {
            Debug.LogException(e, this);
        }
    }
}
