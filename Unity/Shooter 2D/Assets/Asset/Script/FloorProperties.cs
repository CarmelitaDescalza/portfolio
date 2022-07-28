using UnityEngine;
using System.Collections;

public class FloorProperties : MonoBehaviour {

	//Mediante este script marcaremos la durabilidad de los elementos de la escena que puedan dificultar al jugador su avance.


	void OnCollisionEnter (Collision other)
	{
		if(other.gameObject.tag == "Floor")
		{
			Destroy (other.gameObject,10);
		}
	}
}
