using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour {

	public Mover Movement1 = new MoveStraight ();
	//public Mover Movement2 = new MoveAngle();
	//public Mover Movement3 = new MoveJitter();


	// Update is called once per frame
	void FixedUpdate () {
		Movement1.MoveAsteroid (transform);
	}
}
