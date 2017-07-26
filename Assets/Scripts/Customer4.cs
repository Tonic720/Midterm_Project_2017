using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Customer4 : MonoBehaviour {

	public Transform target;
	public Transform target2;
	public Transform adam;
	public Transform player; 
	public Text orderText;
	public Order_Crate crate;
	public Customer3 cus3;

	public bool chedderGot = false;
	//public bool chedderGot2 = false;
	public bool swissGot = false;
	public bool goudaGot = false;
	//public int chedder = 0;
	public bool orderComplete;

	NavMeshAgent agent;
	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent>();
		//crate = GetComponent<Order_Crate>();


	}
	
	// Update is called once per frame
	void Update () {
		if (crate.swiss4Count >= 4) {
			swissGot = true;
		}
		if (crate.gouda4Count >= 4) {
			goudaGot = true;
		}
		
		if (chedderGot && swissGot && goudaGot) {
			orderComplete = true;
		} else {
			orderComplete = false;
		}



		if (Vector3.Distance (adam.position, transform.position) < 4f && Vector3.Distance (player.position, transform.position) < 3f) {
			orderText.text = "Hey could i get like 2 Wedges of swiss and gouda along with one block of chedder";
		} else {
			orderText.text = " ";
		}

		if(cus3.orderComplete && !orderComplete){
			agent.SetDestination (target.position);
		} else if (orderComplete) {
			agent.SetDestination (target2.position);

		}

		GotOrder ();

	}
	void GotOrder(){
		

		if (crate.isChedder4 == true) {

			chedderGot = true;



		}


//		if (crate.isSwiss4 == true) {
//
//			swissGot = true;
//		}
//		if (crate.isGouda4 == true) {
//			goudaGot = true;
//		}


	}
}
