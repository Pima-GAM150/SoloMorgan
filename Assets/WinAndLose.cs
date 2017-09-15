using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinAndLose : MonoBehaviour {

	public GameObject deadText;
	public GameObject refTimer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (transform.position.y < -3) {
			deadText.gameObject.SetActive (true);
			refTimer.GetComponent<Timer> ().TimeStop ();
		} 
		else {
			deadText.gameObject.SetActive (false);
		}
	}
}
