using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinAndLose : MonoBehaviour {

	public GameObject deadText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (transform.position.y < -3) {
			deadText.gameObject.SetActive (true);
		} 
		else {
			deadText.gameObject.SetActive (false);
		}
	}
}
