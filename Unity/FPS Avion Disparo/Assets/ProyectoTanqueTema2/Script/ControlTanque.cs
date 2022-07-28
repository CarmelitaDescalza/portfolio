using UnityEngine;
using System.Collections;

public class ControlTanque : MonoBehaviour {

	// Crearemos dos variables float que nos permitirán controlar la velocidad de translación  rotación desde el inspector de Unity.

	public float velT;
	public float velR;


	
	//En el método Update escribimos el código que nos permitirá mover el tanque en función de los Imput de teclado que le asignemos.

	void Update () {

		if (Input.GetKey(KeyCode.W)){
			this.transform.Translate (velT*Time.deltaTime,0,0);
		}
		if (Input.GetKey(KeyCode.S)){
			this.transform.Translate (-velT*Time.deltaTime,0,0);
		}
		if (Input.GetKey(KeyCode.A)){
			this.transform.Rotate (0, -velR*Time.deltaTime, 0);
		}
		if (Input.GetKey(KeyCode.D)){
			this.transform.Rotate (0, velR*Time.deltaTime, 0);
		}
	
	}
}
