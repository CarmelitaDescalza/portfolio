using UnityEngine;
using System.Collections;

public class EnemyOne : MonoBehaviour {

	//Creamos una variable Game Object que repesente al Jugador y otra vector3 que represente la distancia entre el enemigo y el jugador.
	public GameObject refPlayer;
	public Vector3 distance;

	//Creamos una variable GameObject que contenga la representación de la posición de inicio del enemigo principal al reaparecer en escena.
	public GameObject startEnemyOnePoint;

	// Use this for initialization
	void Start () {

		distance = refPlayer.transform.position - this.transform.position;
	
	}
	
	// Ahora le damos valor a la variable vector y escribimos las instrucciones necesarias para que el enemigo siga y vaya acercandose al tanque.
	void Update () {
		distance = refPlayer.transform.position - this.transform.position;
		this.transform.Translate (distance*Time.deltaTime*0.1f* Random.Range(1,10));

	}

	//Este método nos permite que el objeto que colisione con el suelo respawn vuelva a aparecer en el lugar que le asignemos y que representa la variable GameObjet declarada al inicio.
	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.tag == "Respawn") 
		{
			this.transform.position = startEnemyOnePoint.transform.position;
		}
	}
}
