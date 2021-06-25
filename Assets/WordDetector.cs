using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordDetector : MonoBehaviour
{
    public AudioSource sAvion;
    public AudioSource sOso;
    public AudioSource sElefante, wrong;
    [HideInInspector]
    public string palabra;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Objeto: " + collision.gameObject.name);

        foreach (ContactPoint contact in collision.contacts)
        {
            print(contact.thisCollider.name + " hit " + contact.otherCollider.name);
            // Visualize the contact point
            if(contact.otherCollider.name != gameObject.name)
            {
                palabra = "wrong";
            }
            else
            {
                palabra = contact.otherCollider.name;
            }
            
            switch (palabra)
            {
                case "cAvion":
                    sAvion.Play(0);
                    break;
                case "cOso":
                    sOso.Play(0);
                    break;
                case "cElefante":
                    sElefante.Play(0);
                    break;
                default:
                    wrong.Play(0);
                    break;
            }
            /*
            try
            {
                if (contact.otherCollider.name == "cAvion" && contact.thisCollider.name == this.gameObject.name)
                {
                    sAvion.Play(0);
                }
                else if (contact.otherCollider.name == "cOso" && contact.thisCollider.name == this.gameObject.name)
                {
                    sOso.Play(0);
                }
                else if (contact.otherCollider.name == "cElefante" && contact.thisCollider.name == this.gameObject.name)
                {
                    sElefante.Play(0);
                }
                else if(contact.otherCollider.name != contact.thisCollider.name)
                {
                    wrong.Play(0);
                }
            }
            catch (Exception e)
            {
                Debug.LogException(e, this);
            }
            */
            /*
            Rigidbody rBody = GetComponent<Rigidbody>();
            rBody.isKinematic = false;
            rBody.detectCollisions = true;*/
            //Debug.Log("Resultado = " + resultado);
        }

    }
}
