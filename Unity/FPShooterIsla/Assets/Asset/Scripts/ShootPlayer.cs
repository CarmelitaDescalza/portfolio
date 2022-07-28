using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShootPlayer : MonoBehaviour {

	//Creamos las variables que necesitaremos para realizar los disparos del jugador.

	//El prefabs que se instanciará en newKnife.
	public GameObject _originalKnife; 
	//El punto y dirección de lanzamiento.
	public Transform  _throwPoint; 
	//El valor de fuerza del lanzamiento.
	public float _force;
	//El número de cuchillos con los que se empieza.
	public int _knivesStart;
	//El número de cuchillos que quedan.
	public int _currentKnives;
	//El referente del texto del canvas.
	public Text _knivesText;


	// Use this for initialization
	void Start () {
		
		//Al comienzo deberá ser igual el número de cuchillos con los que se empieza y los que quedan.
		_currentKnives=_knivesStart;
	
	}
	
	// Update is called once per frame
	void Update () {

		//Mediante el siguiente condicional de Input instanciaremos los cuchillos siempre que quede alguno y se irán restando según vayan siendo lanzados.

		if(Input.GetKeyDown(KeyCode.X) && _currentKnives > 0){

			_currentKnives = _currentKnives-1;
			
			//Instanciamos y creamos nuevos cuchillos.
			GameObject _newKnife = (GameObject)Instantiate(_originalKnife,_throwPoint.position,_throwPoint.rotation);

			//Y los lanzamos.
			_newKnife.GetComponent<Rigidbody> ().AddForce (_throwPoint.forward*_force,ForceMode.Impulse);
		}

		//La variable que representa el texto del contador de cuchillos adquiere valor y es actualizada constantemente en el método update.
		_knivesText.text= "Knives number: " +  _currentKnives + "/" + _knivesStart;
	
	}
}
