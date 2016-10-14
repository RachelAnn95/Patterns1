using UnityEngine;
using System.Collections;

[System.Serializable]
public class MoveJitter : Mover {

	// Use this for initialization
	public override void MoveAsteroid (Transform t) {

		Vector3 v = new Vector3 (Random.Range (-0.03f, 0.03f), Random.Range (-0.03f, 0.03f), Random.Range (-0.03f, 0.03f));

		t.position = t.position + v + t.forward * 0.01f;
	}

}
