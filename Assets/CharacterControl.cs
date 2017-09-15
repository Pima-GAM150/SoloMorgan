using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour {

    private float Horizontal;
	private float depth;
	public float speed;
	public CharacterController controller;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
											//parameter
		Horizontal = Input.GetAxis ("Horizontal");
		depth = Input.GetAxis ("Depth");
		controller.SimpleMove (new Vector3 (Horizontal, 0f, depth) * Time.deltaTime * speed);
	}
}
