using UnityEngine;
using System.Collections;

public class PlayerShot : MonoBehaviour {

	//Creamos las variables que vamos a necesitar para crear la función de disparo del jugador.
	 
	//Un Game Onbect que contiene la referencia de la bala original que instanciaremos.
	public GameObject _originalBullet;
	//Un Game Object que contendrá la posición desde la que queremos que salga el disparo.
	public GameObject _shotPoin;
	//Una variable float para contener la velocidad de disparo.
	public float _shootSpeed = 12f;
	//Una variable Vector3 que nos ayudará a marcar la dirección en la que queremos que salga la bala.
	public Vector3 _shotVector;

	//Una variable que contenga el método Animator.
	public Animator myAnim;
	public Animator myAnim2;


	// Use this for initialization
	void Start () {

		//Al iniciar el juego queremos que el vector de disparo vaya hacia el eje x en positivo.
		_shotVector= new Vector3 (_shootSpeed,0,0);
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Escribimos los métodos que contienen las funciones de este script. Cambio de dirección del vector de disparo y disparar.

		RoutChange ();

		Shoot ();

	}

	//Crearemos un método que contendrá el código que define el disparo.
	public void Shoot()
	{
		if (Input.GetKeyDown (KeyCode.P)) 
		{	
			//Instanciamos la bala original.
			GameObject _newBullet = (GameObject)Instantiate (_originalBullet, _shotPoin.transform.position, this.transform.rotation);
			//A las nuevas balas les asignamos la función velocity del componente rigidbody para darle movimiento y el vector susceptible de cambio..
			_newBullet.GetComponent<Rigidbody> ().velocity = _shotVector;

			//Cargamos la animación correspondiente al disparo.
			myAnim.SetTrigger("Shoot");
			myAnim2.SetTrigger("Shoot");

			//Y cuando pasen 5 segundos se autodestruirán.
			Destroy (_newBullet,5);

		}

	}
	//Crearemos un método que cambia el sentido del vector que asigna velocidad a las balas según los comandos asignados al movimiento.
	public void RoutChange ()

	{
		if (Input.GetKey(KeyCode.A))
		{
			_shotVector = new Vector3 (-_shootSpeed,0,0);
		}

		if (Input.GetKey(KeyCode.D))
		{
			_shotVector = new Vector3 (_shootSpeed,0,0);
		}


	}
}
