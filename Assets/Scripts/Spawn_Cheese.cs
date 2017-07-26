using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Cheese : MonoBehaviour {

	public GameObject cheese;
	public Transform player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.R) && Vector3.Distance (player.position, transform.position) < 1f) {

			Instantiate (cheese, transform.position, transform.rotation);
		}
		
	}
}
