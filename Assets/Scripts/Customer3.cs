using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
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


	public Text timeLimit;
	public float timeLeft = 35;

	NavMeshAgent agent;
	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent>();
		//crate = GetComponent<Order_Crate>();


	}

	// Update is called once per frame
	void Update () {

		//if (crate.chedder3 > 6 || crate.swiss3Counter > 4 || crate.gouda3Counter > 4) {
			//SceneManager.LoadScene ("GameOver");
		//}


		// Fixed version
		if (crate.chedder3 > 4 ) {
			SceneManager.LoadScene ("GameOver");
		}
		if (crate.swiss3Counter > 3   ) {
			SceneManager.LoadScene ("GameOver");
		}
		if (crate.gouda3Counter > 3 ) {
			SceneManager.LoadScene ("GameOver");
		}

		if (crate.chedder3 >= 4) {
			chedderGot = true;
		}
		if (chedderGot && swissGot && goudaGot) {
			orderComplete = true;
		} else {
			orderComplete = false;
		}



		if (Vector3.Distance (adam.position, transform.position) < 4f && Vector3.Distance (player.position, transform.position) < 10f) {
			orderText.text = "I would like two blocks of chedder, one Gouda, and one thing of Swiss";
		} else {
			orderText.text = " ";
		}

		if(cus2.orderComplete && !orderComplete){
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
