using UnityEngine;
using System.Collections;

public class MotionPlane : MonoBehaviour {


	//Declaramos las variables que vamos a necesitar para este script, la velocidad constante y los valores de rotación y un tercer valor de acompañamiento a la rotación.

	public float velC;
	public float valR;
	public float valA;

	private float currentSpeed = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// En el Update llamaremos a los métodos que hemos creado más adelante para que se ejecuten.
	void Update () {

		ConstantMotion ();	
		RotaryMotion ();
	
	}

	// Crearemos un método para generar un movimiento constante. Lo hacemos mediante el componente transform.
	void ConstantMotion ()
	{
		this.transform.Translate (0,currentSpeed*Time.deltaTime,0);
	}

	// Crearemos un método que contenga el movimiento de rotación del avión.
	void RotaryMotion (){

		if (Input.GetKey (KeyCode.A)) {
			this.transform.Rotate (0,valR, 0);	
			this.transform.Rotate (-valA,0,0 );
		}

		if (Input.GetKey (KeyCode.D)) {
			this.transform.Rotate (0,-valR, 0);
			this.transform.Rotate (valA,0,0);
		}
			
		if (Input.GetKey (KeyCode.W)) {
			this.transform.Rotate (0,0,valR);
		}

		if (Input.GetKey (KeyCode.S)) {
			this.transform.Rotate (0,0,-valR);

		}

		if(Input.GetKey(KeyCode.X))
		{
			currentSpeed = velC;
		}
	}
}
