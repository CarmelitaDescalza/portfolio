using UnityEngine;
using System.Collections;

public class EnemyOneMovement : MonoBehaviour {

	//Creamos las variables que interceden en el movimiento del enemigo;
	//La velocidad.
	public float _enemySpeed;
	//La dirección. Asignaremos una global por defecto hacia la derecha.
	public Vector3 _enemyRoutVector = Vector3.right;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Para asignarle movimiento al enemigo utilizaremos el método translate.
		this.transform.Translate(_enemyRoutVector *_enemySpeed * Time.deltaTime, Space.World);
	
	}
}
