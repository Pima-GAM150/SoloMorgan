using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wayPointChase : MonoBehaviour {

	public GameObject wayPoint;
	public Vector3 wayPointPos;

	public float speed = 0f;
	// Use this for initialization
	void Start () {
		wayPoint = GameObject.Find ("wayPoint");
	}
	
	// Update is called once per frame
	void Update () {
		wayPointPos = new Vector3(wayPoint.transform.position.x, transform.position.y, wayPoint.transform.position.z);
		transform.position = Vector3.MoveTowards (transform.position, wayPointPos, speed += 0.005f * Time.deltaTime);
	}
}
