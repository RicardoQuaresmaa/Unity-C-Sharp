using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningStatements : MonoBehaviour {

	public bool imLateForMeeting = true;
	public bool roadConditionsArePerfect = true;

	void Start () {

		if (imLateForMeeting && roadConditionsArePerfect) {
		 //	Debug.Log("I need to drive fast");
		}

		// Other ();
	}


	public bool imHugry = false;
	public bool areKidsHungry = true;


	void Other () {

		if (imHugry || areKidsHungry) {
			Debug.Log("I should cook some food");
		}
	}


}
