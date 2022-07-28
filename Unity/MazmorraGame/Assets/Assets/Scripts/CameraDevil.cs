using UnityEngine;
using System.Collections;

public class CameraDevil : MonoBehaviour {

	//Creamos las variables que contendrán el objeto que queremos divisar con la cámara y el vector que marca la distancia entre la cámara y este objetivo.

	public GameObject playerReference;
	public Vector3 distanceCameraPlayer;

	// Use this for initialization
	void Start () {

		//El vector de la distancia se calcula al empezar la escena y será la posición de la cámara menos la posición del objetivo
		distanceCameraPlayer = this.transform.position - playerReference.transform.position;

	
	}
	
	// Update is called once per frame
	void Update () {

		//La cámara variará su posición en función del movimiento del objetivo manteniéndose a una distancia constante.
		this.transform.position = playerReference.transform.position + distanceCameraPlayer;
	
	}
}
