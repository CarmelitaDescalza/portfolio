using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LivesSistem : MonoBehaviour {

	//Creamos una variable pública para asignarle vidas al jugador.
	public int _livesPlayer;

	//Creamos una variable que nos indiquen si el jugador ha conseguido o no las vidas.
	public bool _haveNewLive;

	//Creamos una variable que represente el componente renderer:
	public Renderer _myRender;

	//Creamos unas variables que contengan el GameObject de los efectos especiales que instanciaremos.
	public GameObject _specialEffectsOriginal;

	//Creamos una referencia de posición para que reaparezca el jugador.
	public GameObject _startPlayerPoint;

	//Contador gráfico de barra de vida.
	public Image _bar;

	//Contador de vida máxima.
	public int _topLives = 5;



	// Use this for initialization
	void Start () {

		//El jugador comienza con 5 vidas.
		_livesPlayer = 5;


	}
	
	// Update is called once per frame
	void Update () {

		//Creamos una variable float que represente el valor que se verá en la imagen
		float _liveForGrafics = (float)_livesPlayer/_topLives;
		_bar.fillAmount = _liveForGrafics;

		if (_livesPlayer<=0)
		{

			//Un sistema de partículas para el momento del game over.
			Instantiate(_specialEffectsOriginal,this.transform.position,this.transform.rotation);

			//Luego el jugador se hace invisible.
			_myRender= this.GetComponent<Renderer> ();
			_myRender.enabled = false;

			//Stop del juego. Fin de la partida.

		}
	
	}

	void OnCollisionEnter (Collision other)
	{
		///Si el jugador se unde reaparece en el punto que asignemos.
		if (other.gameObject.tag == "Respawn") {
			this.transform.position = _startPlayerPoint.transform.position;
		}

		//Mediante este condicional si el jugador cae pierde una vida.
		if (other.gameObject.tag == "Respawn") {
			_livesPlayer = _livesPlayer - 1;
		}

		//Si un coco collisiona con el jugador, éste pierde una vida.
		if (other.gameObject.tag == "coco") {
			_livesPlayer = _livesPlayer - 1;
			Destroy (other.gameObject);
		}

		//Si un enemigo collisiona con el jugador, éste pierde una vida.
		if (other.gameObject.tag == "enemy") {
			_livesPlayer = _livesPlayer - 1;
			Destroy (other.gameObject);
		}


	}

	void OnTriggerEnter (Collider other)
	{
		//Para recargar las vidas sumando 1.
		if (other.gameObject.tag == "live" && _livesPlayer < 5) {
			_livesPlayer = _livesPlayer + 1;
			Destroy (other.gameObject);
		}
	}


}
