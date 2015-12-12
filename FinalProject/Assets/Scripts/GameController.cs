using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject [] obstacles = new GameObject[5];
	private GameObject[] Levels = new GameObject[5];
	public GameObject character;
	public GameObject finishLine;
	private float pos = 0;
	private float ypos = 0.01f;

	public static float coinCount = 0;

	public Text coinText;

	public GameObject water;

	public static float finalSecond = 0f;
	public static float finalMinute = 0f;

	void Start () {

		NextLevel ();

	}

	//coinText wont update in the GetCoin function for some reason, works in the update function
	void Update(){

		coinText.text = "Coins: " + coinCount;

	}

	public void GetCoin(){

		coinCount++;

	}
	

	//Use this method to wipe the level and then call NextLevel to generate the next
	//To DO:: Make load inbetween level scene (Shop? 'Congrats' Screen?)
	public void BeatLevel(){

		GameObject.Find ("Timer Text").GetComponent<TimerScript> ().ResetTimer ();
		finalSecond = GameObject.Find ("Timer Text").GetComponent<TimerScript> ().seconds;
		finalMinute = GameObject.Find ("Timer Text").GetComponent<TimerScript> ().minutes;

		Object[] objects = GameObject.FindObjectsOfType (typeof(GameObject));

		foreach (Object thing in objects) {
			if(thing.name != "Game Overlay" && thing.name != "Timer Text" && thing.name != "Coin Text" && thing.name != "GameController" && thing.name != "Directional Light")
				Destroy (thing);		

		}
		pos = 0;
		ypos = 0.01f;
		NextLevel ();

	}

	//Generate a level by picking a random obstacle out of the predefined array, then adding
	//It to the actual array of toGenerate called Levels, and instantiates them
	void NextLevel(){

		coinCount = 0;

		Instantiate (water, new Vector3 (-40f, -5f, 0), Quaternion.identity);

		for (int i = 0; i < 5; i++) {
			
			Levels[i] = obstacles[Random.Range(0,5)];
			
		}
		
		foreach (GameObject obstacle in Levels) {
			Instantiate (obstacle, new Vector3 (pos, ypos, 0), Quaternion.identity);
			pos -= 22;
			ypos += 0.01f;
		}

		Instantiate (finishLine, new Vector3(pos + 10f, 0.55f, 0.16f), Quaternion.identity);
		Instantiate (character, new Vector3 (13.5f, 0.5f, 0.16f), Quaternion.Euler(0, -90f, 0));

	}

	public void GameOver(){

		finalSecond = GameObject.Find ("Timer Text").GetComponent<TimerScript> ().seconds;
		finalMinute = GameObject.Find ("Timer Text").GetComponent<TimerScript> ().minutes;
		Application.LoadLevel (1);


	}

	public string GetTime(){

		return finalMinute + ":" + finalSecond;

	}

	public float GetCoins(){

		return coinCount;

	}

}
