using UnityEngine;
using System.Collections;

public class AndysComing : MonoBehaviour {
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Q)) {
			anim.SetBool ("Andy", true);
		}

		if (Input.GetKeyDown(KeyCode.E)) {
			anim.SetBool ("Andy", false);
		}
	}
}
