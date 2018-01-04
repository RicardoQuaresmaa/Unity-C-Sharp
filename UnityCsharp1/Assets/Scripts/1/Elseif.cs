using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elseif : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// speedLimit ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void speedLimit(){
		int speedLimit = 60;

		if (speedLimit == 70) {
			Debug.Log("I can drive at maximum speed");
		}
		else if (speedLimit < 70 && speedLimit >= 30) {
			Debug.Log("Speed limit is less than 70 and more or equals to 30");
		}
		else if (speedLimit < 30) {
			Debug.Log("I better be driving slowly, 30 mph or less");
		}
	}
}
