using UnityEngine;
using System.Collections;

public class EnemyLivesSystem : MonoBehaviour {

	//Script para controlar la vida de los enemigos.
	public void OnCollisionEnter (Collision other){

		//Si una bala collisiona con el enemigo, éste se destruye.
		if (other.gameObject.tag == "Bullet") {

			Destroy (this.gameObject);
		}
	}
}
