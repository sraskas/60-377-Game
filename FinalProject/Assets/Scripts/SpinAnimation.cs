using UnityEngine;
using System.Collections;

public class SpinAnimation : MonoBehaviour
{
	public float speed = 10f;
	public GameController controller;

	//Set the coins to not scale off the obstacle and reset their sizes
	void Start(){

		transform.parent = null;
		transform.localScale = new Vector3 (0.2f, 1f, 1f);

	}

	void Update ()
	{
		transform.RotateAround(Vector3.up, speed * Time.deltaTime);

	}

	void OnTriggerEnter(Collider col){

		if (col.transform.tag == "Player") {
			controller.GetCoin ();
			Destroy (gameObject);
		}

	}
}