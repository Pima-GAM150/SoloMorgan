using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	float timeLeft = 35f;
	public GameObject winText;
	public Text text;
	public GameObject player;
	private bool winCondition = true;

		// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (winCondition) {
			timeLeft -= Time.deltaTime;
			text.text = "Time Left:" + Mathf.Round (timeLeft);
			if (timeLeft < 0) {
				timeLeft = 0;
				winText.gameObject.SetActive (true);
			} 
			else {
				winText.gameObject.SetActive (false);
			}
				
		}
			
	}
	public void TimeStop()
	{
		winCondition = false;
	}	
}
