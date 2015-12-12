using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverTime : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		GameController controller = new GameController ();

		GetComponent<Text>().text = "Time of Death: " +  controller.GetTime();

	}

}
