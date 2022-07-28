using UnityEngine;
using System.Collections;

public class ThrowBullets : MonoBehaviour {

	//Creamos las variables que necesitamos para el script, en este caso necesitamos una variable GameObjet que represente la bala original que instanciaremos al dispararla

	public GameObject originalBullet;
	public float vel;



	// Use this for initialization
	void Start () {
	
	}
	
	// Llamamos al método de lanzar balas que hemos creado a continuación.
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			ThrowB();
		}
	
	}

	//Creamos un método para instanciar balas que tenemos creadas en un prefabs.
	// Si usamos su componente rigidbody y le damos movimiento a las balas éstas salen siempre hacia la misma dirección.

	void ThrowB()
	{
		GameObject newBullet;
		newBullet = (GameObject)Instantiate (originalBullet, this.transform.position, this.transform.rotation);

			
	
		Rigidbody cloneRigid;
		cloneRigid = newBullet.GetComponent<Rigidbody> ();
		cloneRigid.velocity = this.transform.up * vel;


		//Pero si en vez de usar el vector usamos el this.transfom . y su vector interno hacia el que queremos que vaya, las balas van de frente.

			
	}
}
