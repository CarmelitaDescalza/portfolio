using UnityEngine;
using System.Collections;

public class DispararProyectiles : MonoBehaviour {

	//Creamos dos variables públicas que contendrán referencias de los Game Object que necesitaremos para instanciar las balas.

	public GameObject refOriginal;
	public GameObject puntoDisparo;


	// En el siguiente método crearemos un condicional con Imput que si se verifica verdadero ejecutará una instancia de la bala en un lugar determinado.
 
	void Update () {

		if(Input.GetKeyDown(KeyCode.Space)){
			Instantiate (refOriginal, puntoDisparo.transform.position, this.transform.rotation);
		}
	
	}
}
