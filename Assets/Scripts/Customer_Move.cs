using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Customer_Move : MonoBehaviour {

	public Transform target;
	public Transform target2;
	public Transform adam;
	public Transform player; 
	public Text orderText;
	public Text timeLimit;
	public Order_Crate crate;

	public float timeLeft = 35;

	public bool chedderGot = false;
	public bool swissGot = false;
	public bool goudaGot = false;
	public bool orderComplete;

	NavMeshAgent agent;


	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent>();
		//crate = GetComponent<Order_Crate>();
		agent.SetDestination (target.position);
		
	}
	
	// Update is called once per frame
	void Update () {



		timeLimit.text = "Timer: " + timeLeft;


		if (chedderGot == true && swissGot == true) {
			orderComplete = true;
		} else {
			orderComplete = false;
		}

		if (orderComplete) {
			agent.SetDestination (target2.position);
			
		}

		if (Vector3.Distance (adam.position, transform.position) < 4f && Vector3.Distance (player.position, transform.position) < 3f) {
			orderText.text = "Hey i would like half a pound of swiss and chedder and hurry it up I'm in a rush";

		} else {
			orderText.text = " ";
		}
		if (Vector3.Distance (adam.position, transform.position) < 4f) {
			timeLeft -= Time.deltaTime;
		}

		if (timeLeft <= 0) {
			SceneManager.LoadScene ("GameOver");
		}
		

		//if (Input.GetKey (KeyCode.G)) {
			



		//} else if(Input.GetKey (KeyCode.K)) {
			
		//}
		GotOrder();
	}

	void GotOrder(){

		if (crate.isChedder == true) {

			chedderGot = true;
		}
		if (crate.isSwiss == true) {

			swissGot = true;
		}


	}
}
