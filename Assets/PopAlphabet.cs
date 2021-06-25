using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopAlphabet : MonoBehaviour
{
    public GameObject Abecedario;
    public AudioSource OnTouchSound;
    void Start()
    {
        Abecedario = GameObject.Find("Abecedario");
        Abecedario.SetActive(false);
    }

    private void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.tag == "Hands" || collider.gameObject.name == "GrabVolumeBig" || collider.gameObject.name == "GrabVolumeSmall")
        {
            Debug.Log("You touched me, mmmmmmmmmm");
            //Instantiate(Numeritos).transform.SetPositionAndRotation(new Vector3(-67.15f, 8.32f, -7.64f), new Quaternion(0, 0, 0, 0));
            if (this.gameObject.name == "BotonAbecedario")
            {
                OnTouchSound.PlayDelayed(1);
                Abecedario.SetActive(true);
            }

        }

    }
}
