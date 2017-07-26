using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
public class Customer2 : MonoBehaviour {
	public Transform target;
	public Transform target2;
	public Transform adam;
	public Transform player; 
	public Text orderText;
	public Order_Crate crate;
	public Customer_Move cus1;

	public bool chedderGot = false;
	public bool swissGot = false;
	public bool goudaGot = false;
	public bool orderComplete;

	NavMeshAgent agent;
	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent>();
		//crate = GetComponent<Order_Crate>();


	}
	
	// Update is called once per frame
	void Update () {
		if (chedderGot == true && swissGot == true && goudaGot) {
			orderComplete = true;
		} else {
			orderComplete = false;
		}



		if (Vector3.Distance (adam.position, transform.position) < 4f && Vector3.Distance (player.position, transform.position) < 3f) {
			orderText.text = "Give me some Chedder, some Swiss and you know what let's do some Gouda";
		} else {
			orderText.text = " ";
		}

		if(cus1.orderComplete && !orderComplete){
			agent.SetDestination (target.position);
		} else if (orderComplete) {
			agent.SetDestination (target2.position);

		}

		GotOrder ();
		
	}
	void GotOrder(){

		if (crate.isChedder2 == true) {

			chedderGot = true;
		}
		if (crate.isSwiss2 == true) {

			swissGot = true;
		}
		if (crate.isGouda2 == true) {
			goudaGot = true;
		}


	}
}
