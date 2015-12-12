using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {

	public float minutes = 0;
	float mseconds = 0;
	public float seconds = 0;
	Text timerText;

	// Use this for initialization
	void Start () {
		timerText = GetComponent<Text> ();
		timerText.text = "00:00:00";
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		mseconds += Mathf.Floor (Time.deltaTime * 100);

		if(mseconds >= 100){
			mseconds = 0;
			seconds ++;
		}
		if (seconds >= 60) {
			seconds = 0;
			minutes++; 
		}


		timerText.text = minutes.ToString () + ":" + seconds.ToString() + ":" + mseconds.ToString();
	}

	public void ResetTimer(){

		mseconds = 0;
		minutes = 0;
		seconds = 0;

	}
	
}