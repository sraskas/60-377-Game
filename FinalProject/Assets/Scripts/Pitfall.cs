using UnityEngine;
using System.Collections;

public class Pitfall : MonoBehaviour {

	void OnCollisionEnter(Collision col){

		if (col.gameObject.tag == "Player")
			col.gameObject.GetComponent<CapsuleCollider> ().isTrigger = true;


	}

}
