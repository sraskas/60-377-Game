using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject [] obstacles = new GameObject[5];
	private GameObject[] Levels = new GameObject[5];
	public GameObject character;
	public GameObject finishLine;
	private float pos = 0;
	private float ypos = 0.01f;

	public static float gemCount = 0;

	void Start () {

		NextLevel ();

	}

	//Use this method to wipe the level and then call NextLevel to generate the next
	//To DO:: Make load inbetween level scene (Shop? 'Congrats' Screen?)
	public void BeatLevel(){

		Object[] objects = GameObject.FindObjectsOfType (typeof(GameObject));

		foreach(Object thing in objects)
			Destroy (thing);

		pos = 0;
		ypos = 0.01f;
		NextLevel ();

	}

	//Generate a level by picking a random obstacle out of the predefined array, then adding
	//It to the actual array of toGenerate called Levels, and instantiates them
	void NextLevel(){

		for (int i = 0; i < 5; i++) {
			
			Levels[i] = obstacles[Random.Range(0,4)];
			
		}
		
		foreach (GameObject obstacle in Levels) {
			Instantiate (obstacle, new Vector3 (pos, ypos, 0), Quaternion.identity);
			pos -= 22;
			ypos += 0.01f;
		}

		Instantiate (finishLine, new Vector3(pos + 10f, 0.55f, 0.16f), Quaternion.identity);
		Instantiate (character, new Vector3 (13.5f, 0.5f, 0.16f), Quaternion.Euler(0, -90f, 0));

	}

}
