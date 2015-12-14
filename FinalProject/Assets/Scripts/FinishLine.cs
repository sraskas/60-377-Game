using UnityEngine;
using System.Collections;

public class FinishLine : MonoBehaviour {


	void OnCollisionEnter(Collision col) {

		if (col.transform.tag == "Player")
			Application.LoadLevel (3);

	}
	
}
