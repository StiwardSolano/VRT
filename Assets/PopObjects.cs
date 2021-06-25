using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopObjects : MonoBehaviour
{
    public GameObject Numeritos;
    public AudioSource OnTouchSound;
    void Start()
    {
        Numeritos = GameObject.Find("Numeros");
        Numeritos.SetActive(false);
    }

    private void OnTriggerEnter(Collider collider)
    {
        
        if (collider.gameObject.tag == "Hands" || collider.gameObject.name == "GrabVolumeBig" || collider.gameObject.name == "GrabVolumeSmall")
        {
            Debug.Log("You touched me, mmmmmmmmmm");
            //Instantiate(Numeritos).transform.SetPositionAndRotation(new Vector3(-67.15f, 8.32f, -7.64f), new Quaternion(0, 0, 0, 0));
            OnTouchSound.PlayDelayed(1);
            Numeritos.SetActive(true);
        }

    }
}
