using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverCoins : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameController controller = new GameController ();
		
		GetComponent<Text>().text = "Coins Collected: " +  controller.GetCoins();
		
	}
}
