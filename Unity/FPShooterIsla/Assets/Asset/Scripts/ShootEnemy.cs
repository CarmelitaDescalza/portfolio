using UnityEngine;
using System.Collections;


public class ShootEnemy : MonoBehaviour {

	//Creamos la variables que interceden en este script que tiene por función disparar cada cierto tiempo.

	//El referente del original que instanciaremos para disparar.
	public GameObject _originalCoconut;
	//El lugar y dirección desde la que se dispara.
	public Transform  _throwEnemyPoint; 
	//El valor de fuerza del disparo.
	public float _forceCoconut;
	//El vector que dará la referencia del player;
	public Vector3 _distancePlayer;
	//La referencia de la posición del Player;
	public GameObject _playerReference;

	//Una variable contador de tiempo.
	public float _timeCounter;

	//Una variable de rango de tiempo.
	public float _timeRange;



	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		//El vector que define la distancia con el jugador se estará siempre actualizando.
		_distancePlayer= _playerReference.transform.position - this.transform.position;


		//Haremos un bucle temporal para que disparen los enemigos.

		//Si el temporizador es menor que el rango temporal que queramos el tiempo pasa, si no, se disparará un coco.
		if (_timeCounter < _timeRange)
		{		
			_timeCounter = _timeCounter + Time.deltaTime;	// El temporizador se crea sumando los delta time.

			Debug.Log (_timeCounter); // En la consola se muestra el tiempo transcurrido.

		}
		else 
		{
			Debug.Log ("Se hizo un ciclo");// En la consola se muestra el fin de un ciclo.
			ShootCoconut ();
		}

					
	}

	//Creamos un método que contine el código para el disparo.
	public void ShootCoconut()
	{
		Debug.Log ("Disparo un coco");//Referencia que saldrá por consola.

		//Instanciamos y creamos nuevos cocos.
		GameObject _newCoconut = (GameObject)Instantiate(_originalCoconut,_throwEnemyPoint.position,_throwEnemyPoint.rotation);

		//Y los disparamos.
		_newCoconut.GetComponent<Rigidbody> ().AddForce (_distancePlayer*_forceCoconut,ForceMode.Impulse);

		//Tras el disparo el contador, el temporizador se pone denuevo en 0.
		_timeCounter = 0.0f;
	}

	public void OnCollisionEnter (Collision other){

		//Si un cuchillo collisiona con el enemigo, éste se destruye.
		if (other.gameObject.tag == "knife") {
			
			Destroy (this.gameObject);
		}
			
	}
}
