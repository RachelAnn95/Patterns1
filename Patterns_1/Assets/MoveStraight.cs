using UnityEngine;
using System.Collections;

[System.Serializable]
public class MoveStraight : Mover {

	// Use this for initialization
	public override void MoveAsteroid (Transform t) {
		t.position = t.position + t.forward * 0.1f;
	}

}
	
