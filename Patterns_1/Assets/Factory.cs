using UnityEngine;
using System.Collections;

public class Factory : MonoBehaviour {

	public GameObject make;
	public Vector3 v;

	void Start() {
		StartCoroutine (execute ());
	}



	IEnumerator execute(){
		while (true) {
			yield return new WaitForSeconds (.1f);
			Object o = Instantiate(make, v, Quaternion.identity);
			GameObject go = (GameObject)o;
			Asteroid a = go.GetComponent<Asteroid> ();
			int choice = Random.Range (0, 2);
			if (choice == 0) {
				a.Movement1 = new MoveStraight ();
			} else if (choice == 1) {
				a.Movement1 = new MoveAngle ();
			} else {
				a.Movement1 = new MoveJitter ();
			}
		}
	}
	
	// Update is called once per frame
	/*void Update () {
		Object o = Instantiate(make, v, Quaternion.identity);
		GameObject go = (GameObject)o;
		Asteroid a = go.GetComponent<Asteroid> ();
		int choice = Random.Range (0, 2);
		if (choice == 0) {
			a.Movement1 = new MoveStraight ();
		} else if (choice == 1) {
			a.Movement1 = new MoveAngle ();
		} else {
			a.Movement1 = new MoveJitter ();
		}
	}*/
}
