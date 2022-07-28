using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	//Creamos las variables que vamos a necesitar para que el player salte, pero que no salte hasta el infinito.
	//El componente RigidBody.
	public Rigidbody _myRigid;
	//La velocidad con la que se lanzará.
	public float _speedJump;
	//Un booleano de si toca o no el suelo.
	public bool _floorTouch = false;

	//Creamos las variables que vamos a necesitar para que el player se mueva.
	public float _speedMovement;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//La booleana se actualiza constante mente a falso excepto cuando se cumpla con las condiciones que se especifican en el método Junmping.
		_floorTouch = false;


		//Método que contiene la acción de saltar.
		Jumping ();

		//Método que contiene las acciones de movimiento.
		Movement ();
	
	}

	//Creamos un método que contenga todo el código para realizar el salto.
	public void Jumping()
	{
		//Mediante el RayCast averiguaremos si el suelo está debajo o no del jugador, si el rayo lo detecta la booleana será verdadera.

		RaycastHit _resultRay;
		if(Physics.Raycast(this.transform.position,Vector3.down, out _resultRay, 0.55f))
		{
			if (_resultRay.transform.tag == "Floor") 
			{
				_floorTouch = true;
			}
		}

		//Si clickamos el botón de espacio y la booleana es en modo verdadero el jugador saltará. Utilizamos el método velocity del componente RigidBody.

		if (Input.GetKeyDown (KeyCode.Space) && _floorTouch == true) 
		{
			_myRigid.velocity = Vector3.up * _speedJump;
		}
	}

	//Creamos un método que contenga todo el código para realizar el movimiento del jugador.
	public void Movement()
	{
		if (Input.GetKey(KeyCode.A))
		{
			this.transform.Translate (-_speedMovement* Time.deltaTime,0,0, Space.World);

			//Con el componente transform accedemos a la escala y al marcar el inverso en uno de los ejes el jugador en apariencia gira 180 grados en ese eje.
			this.transform.localScale = new Vector3 (-1,1,1);
		}

		if (Input.GetKey(KeyCode.D))
		{
			this.transform.Translate (_speedMovement* Time.deltaTime,0,0, Space.World);


			this.transform.localScale = new Vector3 (1,1,1);
		}
	}
}
