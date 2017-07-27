using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Customer2 : MonoBehaviour {
	public Transform target;
	public Transform target2;
	public Transform adam;
	public Transform player; 
	public Text orderText;

	public Order_Crate crate;
	public Customer_Move cus1;

	public Text timeLimit;
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


	}
	
	// Update is called once per frame
	void Update () {
		//if (crate.chedder2Counter > 4 || crate.swiss2Counter > 4 || crate.gouda2Counter > 4) {
		//	SceneManager.LoadScene ("GameOver"); Code did not work
		//}

		// Fixed version
		if (crate.chedder2Counter > 3 ) {
			SceneManager.LoadScene ("GameOver");
		}
		if (crate.swiss2Counter > 3  ) {
			SceneManager.LoadScene ("GameOver");
		}
		if (crate.gouda2Counter > 3) {
			SceneManager.LoadScene ("GameOver");
			//orderText.text += "Count of gouda " + crate.gouda2Counter;
		}

		 
		if (chedderGot == true && swissGot == true && goudaGot) {
			orderComplete = true;
		} else {
			orderComplete = false;
		}



		if (Vector3.Distance (adam.position, transform.position) < 4f && Vector3.Distance (player.position, transform.position) < 10f) {
			orderText.text = "Give me some Chedder, some Swiss and you know what let's do some Gouda";
		} else {
			orderText.text = " ";
		}

		if(cus1.orderComplete && !orderComplete){
			agent.SetDestination (target.position);
		} else if (orderComplete) {
			agent.SetDestination (target2.position);

		}

		if (Vector3.Distance (adam.position, transform.position) < 4f) {
			timeLeft -= Time.deltaTime;
			timeLimit.text = "Timer: " + timeLeft;
		} 
		if(orderComplete){
			timeLimit.text = "";
		}
		if (timeLeft <= 0) {
			SceneManager.LoadScene ("GameOver");
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
