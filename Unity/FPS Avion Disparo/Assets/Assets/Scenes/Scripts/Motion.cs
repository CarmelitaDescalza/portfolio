using UnityEngine;
using System.Collections;

public class Motion : MonoBehaviour {

	//Declaramos las variables que vamos a necesitar para este script

	public Rigidbody myRigid;
	public float velC;
	public float valR;
	public float valA;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	// En él llamaremos a los métodos que hemos creado más abajo para que se ejecuten

	void Update () {

		Stabilizer ();

		//if(Input.GetKey(KeyCode.X))
		//{
			ConstantMotion ();	
		//}

		//if(Input.GetKey(KeyCode.Z))
		//{
		//	Stop ();	
		//}	
	
		RotaryMotion ();


	}

	// Crearemos un método para generar un movimiento constante
	// Lo hacemos mediante el componente rigidbody al que podemos acceder a traves del GetComponent

	void ConstantMotion ()
	{
		//myRigid = this.GetComponent<Rigidbody>();
		//myRigid.velocity = new Vector3(velC,0,0); 
		this.transform.Translate (0,-velC*Time.deltaTime,0);
	}
	// Crearemos un método para frenar el movimiento constante
	void Stop ()
	{
		//myRigid = this.GetComponent<Rigidbody>();
		//myRigid.velocity = new Vector3(0,0,0); 
		this.transform.Translate (0,0,0);
	}

	// Crearemos un método que contenga el movimiento de rotación y de translación

	void RotaryMotion (){
		
		if (Input.GetKeyDown (KeyCode.A)) {
			
			this.transform.Rotate (-valR, 0, 0 );	
			this.transform.Rotate (0,-valA, 0 );
			//this.transform.Translate (0,0,valT);
		//} else {this.transform.Rotate (0, 0, 0, Space.World);
			
		}


		if (Input.GetKeyDown (KeyCode.D)) {
			this.transform.Rotate (valR,0,0);
			this.transform.Rotate (0,valA,0);
		//} else {this.transform.Rotate (0, 0, 0, Space.World);

		}
			//this.transform.Translate (0,0,-valT);

		if (Input.GetKeyDown (KeyCode.W)) {
			this.transform.Rotate (0,0,-valR);
			//this.transform.Translate (0,-valT,0);
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			this.transform.Rotate (0,0,valR);
			//this.transform.Translate (0,valT,0);
		}
	}
	void Stabilizer ()
	{
		
		this.transform.Rotate (0, 0, 0,Space.World);
	}	

}
