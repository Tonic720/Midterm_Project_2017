using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Customer3 : MonoBehaviour {

	public Transform target;
	public Transform target2;
	public Transform adam;
	public Transform player; 
	public Text orderText;
	public Order_Crate crate;
	public Customer2 cus2;

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

		if (crate.chedder3 >= 4) {
			chedderGot = true;
		}
		if (chedderGot && swissGot && goudaGot) {
			orderComplete = true;
		} else {
			orderComplete = false;
		}



		if (Vector3.Distance (adam.position, transform.position) < 4f && Vector3.Distance (player.position, transform.position) < 3f) {
			orderText.text = "I would like 2 blocks of chedder, one Gouda, and one thing of Swiss";
		} else {
			orderText.text = " ";
		}

		if(cus2.orderComplete && !orderComplete){
			agent.SetDestination (target.position);
		} else if (orderComplete) {
			agent.SetDestination (target2.position);

		}

		GotOrder ();

	}
	void GotOrder(){

//		if (crate.isChedder3 == true) {
//
//			chedderGot = true;
//
//
//
//		}
		 

		if (crate.isSwiss3 == true) {

			swissGot = true;
		}
		if (crate.isGouda3 == true) {
			goudaGot = true;
		}


	}
}
