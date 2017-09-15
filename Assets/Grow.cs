using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.localScale += new Vector3(0.4f, 0.4f, 0.4f) * Time.deltaTime;
		transform.position = new Vector3 (transform.position.x, transform.localScale.y / 2f, transform.position.z);
	}
}
