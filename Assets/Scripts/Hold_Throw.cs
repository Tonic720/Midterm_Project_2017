using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hold_Throw : MonoBehaviour {
	public Transform player;
	public Transform playerCam;

	public  float throwForce = 10;
	bool hasPlayer = false; // checks if player is in range
	bool beingCarried = false;

	private bool touched = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float dis = Vector3.Distance (gameObject.transform.position, player.transform.position);

		if (dis <= 2.5f) {
			hasPlayer = true;
		} else {
			hasPlayer = false;
		}

		if (hasPlayer && Input.GetKeyDown (KeyCode.E)) {
			GetComponent<Rigidbody> ().isKinematic = true;
			transform.parent = playerCam;
			beingCarried = true;
		}
		if (beingCarried) {

			if (touched) {
				GetComponent<Rigidbody> ().isKinematic = false;
				transform.parent = null;
				beingCarried = false;
				touched = false;
			}
			if (Input.GetMouseButton (0)) {
				GetComponent<Rigidbody> ().isKinematic = false;
				transform.parent = null;
				beingCarried = false;
				GetComponent<Rigidbody> ().AddForce (playerCam.forward * throwForce);
			} else if (Input.GetMouseButton (1)) {
				GetComponent<Rigidbody> ().isKinematic = false;
				transform.parent = null;
				beingCarried = false;
			}


			

		}
	}
	void OnTriggerEnter(){
		if(beingCarried){
			touched = true;
		}
	}




}
