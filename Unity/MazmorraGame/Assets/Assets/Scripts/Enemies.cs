using UnityEngine;
using System.Collections;

public class Enemies : MonoBehaviour {
	
	//Creamos una variable pública con la que asignaremos movimiento a los enemigos desde el inspector.
	public Vector3 enemyMovement;

	//Creamos una variable GameObject que contenga la representación de la posición de inicio de los enemigos al reaparecer en escena.
	public GameObject startEnemyPoint;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () 
	{

		//Daremos movimiento a los gameObjects enemigos mediante el método translate.

		this.transform.Translate (enemyMovement);

		//Para que antes de chocar roten en su movimiento usaremos el raicast que detectará las paredes.

		RaycastHit resultRay;
			if (Physics.Raycast (this.transform.position,this.transform.forward,out resultRay,1.5f ))
			{

				if(resultRay.collider.tag == "Wall")
				{
				this.transform.Rotate (0,90,0);
				}
			}
	}

	//Este método nos permite que el objeto que colisione con el suelo respawn vuelva a aparecer en el lugar que le asignemos y que representa la variable GameObjet declarada al inicio.

	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.tag == "Respawn") 
		{
			this.transform.position = startEnemyPoint.transform.position;
		}
	}
}
