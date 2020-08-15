using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {

	//public Animator animacion;
	public float velocidad=10.0f;
	public float rotationspeed=100.0f;

	void Update(){


		if (Input.GetKey (KeyCode.UpArrow)) {
			//animacion.SetBool ("caminar", true);
			transform.Translate (Vector3.right * velocidad * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			//animacion.SetBool ("caminar", true);
			transform.Translate (Vector3.left * velocidad * Time.deltaTime);
		}
			/*
		} 
		else {
			//animacion.SetBool ("caminar", false);
		}

		if (Input.GetKey (KeyCode.C))
			//animacion.SetBool ("Saltar", true);
		else {
			//animacion.SetBool ("Saltar", false);
		}

		if (Input.GetKey (KeyCode.X))
			//animacion.SetBool ("golpe1", true);
		else {
			//animacion.SetBool ("golpe1", false);
		}

		if (Input.GetKey (KeyCode.Z)) {
			//animacion.SetBool ("golpe2", true);

		} else {
			//animacion.SetBool ("golpe2", false);
		}

		if (Input.GetKey (KeyCode.X)) {
			//animacion.SetBool ("ataque", true);

		} else {
			//animacion.SetBool ("ataque", false);
		}
*/
		if (Input.GetKey (KeyCode.LeftArrow)) {

			transform.Rotate (0, Input.GetAxis ("Horizontal") * rotationspeed * Time.deltaTime, 0);
		}


		if (Input.GetKey (KeyCode.RightArrow)) {

			transform.Rotate (0, Input.GetAxis ("Horizontal") * rotationspeed * Time.deltaTime, 0);
		}
	}
}