using UnityEngine;
using System.Collections;

public class ControlPlayerBall : MonoBehaviour {

	//Creamos una variable pública para controlar la velocidad de movimiento del jugador:
	public float speedPlayer;

	//Creamos una variable GameObject que contenga la representación de la posición de inicio del jugador al reaparecer en escena.
	public GameObject startPlayerPoint;

	//Creamos una variable pública para asignarle vidas al jugador.
	public int livesPlayer;

	//Creamos unas variables que nos indiquen si el jugador ha conseguido o no las llaves
	public bool haveBlueKey;
	public bool havePurpleKey;
	public bool haveYelowKey;

	//Creamos unas variables que contengan el GameObject de los efectos especiales que instanciaremos.
	public GameObject specialEffectsOriginal;
	public GameObject specialEffectsOriginal2;

	//Creamos una variable que contenga la referencia desde donde saldrán los fuegos artificiales al final
	public GameObject specialEffectsReference;

	//Creamos una variable que represente el componente renderer:
	public Renderer myRender;


	// Use this for initialization
	void Start () {

		//El jugador comienza con tres vidas.
		livesPlayer = 3;
	
	}
	
	// Update is called once per frame
	void Update () 
	{

		PlayerBallMovement ();

		//Si el jugador llega a 0 vidas, éste desaparece. 	
			if (livesPlayer<=0)
			{

			//Un sistema de partículas decora la escena y marca el momento del game over.
			Instantiate(specialEffectsOriginal,this.transform.position,this.transform.rotation);

			//Luego el jugador se hace invisible.
			myRender= this.GetComponent<Renderer> ();
			myRender.enabled = false;

			}
	
	}

	//Mediante este método asignamos movimiento al jugador con los input del teclado.
	void PlayerBallMovement()
	{
		if (Input.GetKey(KeyCode.W)){
			this.transform.Translate (0,0,speedPlayer*Time.deltaTime,Space.World);
		}
		if (Input.GetKey(KeyCode.S)){
			this.transform.Translate (0,0,-speedPlayer*Time.deltaTime,Space.World);
		}
		if (Input.GetKey(KeyCode.A)){
			this.transform.Translate (-speedPlayer*Time.deltaTime,0, 0,Space.World);
		}
		if (Input.GetKey(KeyCode.D)){
			this.transform.Translate (speedPlayer*Time.deltaTime,0, 0,Space.World);
		}
	}

	void OnCollisionEnter (Collision other)
	{
		//Mediante este condicional el objeto que colisione con el suelo respawn vuelva a aparecer en el lugar que le asignemos y que representa la variable GameObjet declarada al inicio.
		if (other.gameObject.tag == "Respawn") 
		{
			this.transform.position = startPlayerPoint.transform.position;
		}

		//Mediante este condicional si el jugador cae pierde una vida.
		if(other.gameObject.tag == "Respawn")
		{
			livesPlayer = livesPlayer - 1;
		}

		//Mediante este condicional si un enemigo collisiona con el jugador, éste pierde una vida.
		if(other.gameObject.tag == "Enemy")
		{
			livesPlayer = livesPlayer - 1;
		}

		//Para realizar la acción de abrir las puertas cuando se tengan las llaves.
		if (haveBlueKey == true && other.gameObject.tag =="DoorBlue")
		{
			Destroy (other.gameObject);
		}

		if (havePurpleKey == true && other.gameObject.tag =="DoorPurple")
		{
			Destroy (other.gameObject);
		}

		if (haveYelowKey == true && other.gameObject.tag =="DoorYelow")
		{
			Destroy (other.gameObject);
		}

		//Para cerrar el juego y marcar la meta, el jugador acciona unos efectos especiales festivos.
		if(other.gameObject.tag == "End")
		{
			//Un sistema de partículas decora la escena y marca el momento del winer.
			Instantiate(specialEffectsOriginal2,specialEffectsReference.transform.position,specialEffectsReference.transform.rotation);

			//other.gameObject.transform.Translate (0,5,0);
		}


	}

	void OnTriggerEnter (Collider other)
	{
		//Para recargar la variable sumando 1.
		if(other.gameObject.tag == "Lives" && livesPlayer<3)
		{
			livesPlayer = livesPlayer + 1;
			Destroy (other.gameObject);
		}

		//Para realizar la acción de conseguir las llaves.

		if(other.gameObject.tag == "KeyBlue")
		{
			haveBlueKey = true;
			Destroy (other.gameObject);
		}

		if(other.gameObject.tag == "KeyPurple")
		{
			havePurpleKey = true;
			Destroy (other.gameObject);
		}

		if(other.gameObject.tag == "KeyYelow")
		{
			haveYelowKey = true;
			Destroy (other.gameObject);
		}
	}


}
