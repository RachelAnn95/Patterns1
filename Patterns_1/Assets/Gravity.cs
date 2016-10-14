using UnityEngine;
using System.Collections;

public class Gravity : MonoBehaviour {

	private ArrayList observers = new ArrayList ();


	void FixedUpdate() {
		for (int i = 0; i < observers.Count; i++) {
			GameObject sample = (GameObject)observers [i];
			if (sample == null) {
				observers.Remove (i);
				return;
				Vector3 diff = sample.transform.position - transform.position;
				diff.Normalize ();
				sample.transform.position -= diff * 0.04f;
			}
		}

	}

	void OnTriggerEnter(Collider other){
		GameObject go = other.gameObject;
		observers.Add (go);
	}

	void OnTriggerExit(Collider other){
		GameObject go = other.gameObject;
		for (int i = 0; i < observers.Count; i++) {
			if (observers [i] == go) {
				observers.Remove (i);
			}
		}
	}
}
