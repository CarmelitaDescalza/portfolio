using UnityEngine;
using System.Collections;

public class SeguimientoEnemigo : MonoBehaviour {

	//Creamos una variable Game Object que repesente al Tanque y otra vector3 que represente la distancia entre el enemigo y el tanque.

	public GameObject refTanque;
	public Vector3 distancia;

	// Ahora le damos valor a la variable vector y escribimos las instrucciones necesarias para que el enemigo siga y vaya acercandose al tanque.
	void Update () {
		distancia = refTanque.transform.position - this.transform.position;
		this.transform.Translate (distancia*Time.deltaTime*0.1f);
	
	}
}
