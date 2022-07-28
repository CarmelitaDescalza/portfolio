using UnityEngine;
using System.Collections;

public class NewEnemiesOne : MonoBehaviour {

	//Crearemos las variables que interceden en la creación de enemigos desde los puntos spawn, cada cierto tiempo.
	//La variable que contiene el enemigo prefabs.
	public GameObject _originalEnemy;
	//La variable para contar el tiempo.
	public float _count;
	//La variable para marcar el tiempo que queremos de límite.
	public float _limit;
	//Una varable Vector que nos ayudará a actualizar la dirección en la que se mueve el enemigo manualmente desde el inspector dependiendo del spawn.
	public Vector3 _routSpawn = Vector3.right;

	//Los valores del rango del valor aleatorio;
	public int _min;
	public int _max;


	// Use this for initialization
	void Start () {
		//Al empezar la escena marcaremos un tiempo de instanciamiento aleatorio.
		_limit = Random.Range (_min,_max);
	
	}
	
	// Update is called once per frame
	void Update () {

		//Para llenar el contador empleamos el delta time.
		_count = _count + Time.deltaTime;

		//Si el contador alcanza el límite ha pasdo el tiempo que queŕiamos y se instanciará un enemigo.
		if(_count > _limit)
		{
			GameObject _newEnemy = (GameObject)Instantiate (_originalEnemy,this.transform.position,_originalEnemy.transform.rotation);
			//Accedemoss al componente script que creamos para dar movimiento al enemigo y actualizamos en él la dirección en la que se mueve. 
			_newEnemy.GetComponent<EnemyOneMovement>()._enemyRoutVector = _routSpawn;

			//Los enemigos se autodestruirań en 10 segundos.
			Destroy(_newEnemy,10);

			//El contador vuelve a 0 tras la creación de un enemigo.
			_count = 0;
		}
	
	}

	//Para marcar mayor rango de tiempo entre los nacimientos de los enemigos y darle a este tiempo valores aleatorios creamos el siguiente método.
	public void RandomLimit()
	{
		_limit = Random.Range (_min,_max);
	}
}
