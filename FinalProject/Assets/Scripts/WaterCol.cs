using UnityEngine;
using System.Collections;

public class WaterCol : MonoBehaviour {

	void OnTriggerEnter(Collider col){

		if (col.gameObject.tag == "Player") {

			GameObject.Find("GameController").GetComponent<GameController>().GameOver();

		}

	}
}
