using UnityEngine;
using System.Collections;

public class MovimientoBala : MonoBehaviour {

	//Creamos una variable Vector para poder controlar la velocidad desde el inspector de Unity

	public Vector3 vel;
	//public float vel;

	// Dentro del siguiente método escribimos el código que nos permite variar el componente transform de la bala
	void Update () {
		this.transform.Translate (vel*Time.deltaTime);

		//(0,vel*Time.deltaTime,0);
	
	}
}
