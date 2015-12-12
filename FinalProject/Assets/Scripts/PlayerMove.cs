using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public float speed = 5f;
	private bool jump = false;
	private Rigidbody rb;
	private Vector3 jumpVelocity = new Vector3(0,6,0);

	// Use this for initialization
	void Start () {
	
		rb = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (Input.GetKey(KeyCode.W))
			transform.Translate( new Vector3(0,0,speed) * Time.deltaTime);
		if (Input.GetKey(KeyCode.S))
			transform.Translate( new Vector3(0,0,-speed) * Time.deltaTime);
		if (Input.GetKey(KeyCode.A))
			transform.Translate(new Vector3(-speed,0,0) * Time.deltaTime);
		if (Input.GetKey(KeyCode.D))
			transform.Translate(new Vector3(speed,0,0) * Time.deltaTime);

		if (Input.GetKeyDown ("space") && jump == false) {
			jump = true;
			rb.velocity += jumpVelocity;
		}

		//To Control rotation with the mouse
		if(Input.GetAxis("Mouse X")<0 && Input.GetMouseButton(0)){
			transform.Rotate (Vector3.down, 100f * Time.deltaTime);
		}
		if(Input.GetAxis("Mouse X")>0 && Input.GetMouseButton(0)){
			transform.Rotate(Vector3.up, 100f * Time.deltaTime);
		}

	}

	void OnCollisionEnter(Collision col){

		if (col.gameObject.tag == "Platform")
			jump = false;

	}

}
