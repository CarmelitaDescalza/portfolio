using UnityEngine;
using System.Collections;

public class TestLesson3 : MonoBehaviour {

	float deltaTime;
	int number;

	// Use this for initialization
	void Start () {

		deltaTime = GetDeltaTime ();
		Debug.Log (deltaTime);

	//	number = GetRandomNum ();
		Debug.Log (GetRandomNum());


	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	float GetDeltaTime()
	{
		return Time.deltaTime;
	}

	int GetRandomNum()
	{
		int num = Random.Range (0,15);
		return num;
	}
}
