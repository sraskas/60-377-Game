using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject [] obstacles = new GameObject[5];
	public GameObject character;
	private float pos = 0;
	private float ypos = 0.01f;
	void Start () {

		foreach (GameObject obstacle in obstacles) {
			Instantiate (obstacle, new Vector3 (pos, ypos, 0), Quaternion.identity);
			pos -= 22;
			ypos += 0.01f;
		}
		Instantiate (character, new Vector3 (13.5f, 0.5f, 0.16f), Quaternion.Euler(0, -90f, 0));
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
