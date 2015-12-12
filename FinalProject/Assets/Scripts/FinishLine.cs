using UnityEngine;
using System.Collections;

public class FinishLine : MonoBehaviour {


	void OnCollisionEnter(Collision col) {

		if (col.transform.tag == "Player")
			GameObject.Find ("GameController").GetComponent<GameController>().BeatLevel ();

	}
	
}
