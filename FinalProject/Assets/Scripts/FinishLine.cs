using UnityEngine;
using System.Collections;

public class FinishLine : MonoBehaviour {
	
	public GameController controller;

	void OnCollisionEnter(Collision col) {

		if (col.transform.tag == "Player")
			controller.BeatLevel ();

	}
	
}
