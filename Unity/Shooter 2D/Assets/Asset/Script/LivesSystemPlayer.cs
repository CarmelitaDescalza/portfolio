using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LivesSystemPlayer : MonoBehaviour {
	//Mediante este script crearemos el sistema de vidas del jugador y crearemos las variables que se verán en la IU.

	//Creamos una variable que contiene las vidas del jugador.
	public int _livesPlayer;
	//Una variable que representa el componente renderer.
	public Renderer _myRender;
	//Los efectos especiales que instanciaremos, su referente original.
	public GameObject _specialEffectsOriginal1;
	public GameObject _specialEffectsOriginal2;
	public GameObject _specialEffectsOriginal3;
	//Contador para la imagen del IU de la barra de vida.
	public Image _barLife;
	//El referente del texto de vidas del canvas.
	public Text _livesText;
	//Contador de vida máxima.
	public int _topLives = 5;
	//El referente del texto de premio del canvas.
	public Text _prizeText;
	//Para acceder a la luz.
	public Light _myLigth;

	public float _countEnd;
	public float _limitEnd1 = 5f;
	public float _limitEnd2 = 7f;

	// Use this for initialization
	void Start () {

		//El jugador comienza con 5 vidas.
		_livesPlayer = 5;

		//EL contador estará a 0.
		_countEnd = 0;
	
	}
	
	// Update is called once per frame
	void Update () {

		//Creamos una variable float que represente el valor que se verá en la imagen del IU
		float _liveForIU = (float)_livesPlayer/_topLives;
		_barLife.fillAmount = _liveForIU;

		//Si el jugador llega a 0 vidas.
		if (_livesPlayer<=0)
		{
			//Esperamos cinco segundos.
			_countEnd = _countEnd + Time.deltaTime;

			if (_countEnd < _limitEnd1) {
				
				//Salta el sistema de particulas.
				Instantiate (_specialEffectsOriginal3, this.transform.position, this.transform.rotation);
			}

			//El jugador se hace invisible.
			//_myRender= this.GetComponent<Renderer> ();
			//_myRender.enabled = false;

		

			if (_countEnd > _limitEnd2)
			{

			//Y nos lleva a la escena de Game Over fin del juego.
			SceneManager.LoadScene("GameOver");
			}

		}

		//La variable que representa el texto del contador de vidas se actualiza constantemente en el método update.
		_livesText.text= "LIVES: " +  _topLives + "/" + _livesPlayer;
	
	}

	void OnCollisionEnter (Collision other)
	{
		//Si un enemigo collisiona con el jugador, éste pierde una vida.
		if (other.gameObject.tag == "Enemy") {
			_livesPlayer = _livesPlayer - 1;
			Destroy (other.gameObject);
		}
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Prize") 
		{
			//Un sistema de partículas para el momento del premio final.
			Instantiate (_specialEffectsOriginal1, this.transform.position, this.transform.rotation);
			Instantiate (_specialEffectsOriginal2, this.transform.position, this.transform.rotation);

			//Destruimos el huevo premio al conseguirlo.
			Destroy (other.gameObject);

			//Aparece un texto indicando la victoria.
			_prizeText.text = "COGRATULATIONS";

			//Apagamos la luz.
			Destroy(_myLigth.gameObject);

		}
	}
}
