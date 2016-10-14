using UnityEngine;
using System.Collections;

[System.Serializable]
public class MoveAngle : Mover {

	// Use this for initialization
	public override void MoveAsteroid (Transform t) {
		Vector3 v = t.rotation.eulerAngles;
		v.x += Random.Range(-3,4);
		v.y += Random.Range(-3,4);
		v.z += Random.Range(-3,4);

		t.position = t.position + t.forward * 0.1f;
		t.rotation = Quaternion.Euler (v);
	}

}
