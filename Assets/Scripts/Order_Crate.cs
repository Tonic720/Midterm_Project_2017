using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Order_Crate : MonoBehaviour {

	public bool isChedder;
	public bool isSwiss;
	public bool isGouda;
	public int chedder1Counter = 0;
	public int swiss1Counter = 0;
	public int gouda1Counter = 0;

	public bool isChedder2;
	public bool isSwiss2;
	public bool isGouda2;
	public int chedder2Counter = 0;
	public int swiss2Counter = 0;
	public int gouda2Counter = 0;

	public bool isChedder3;
	public bool isSwiss3;
	public bool isGouda3;
	public int chedder3 = 0;
	public int swiss3Counter = 0;
	public int gouda3Counter = 0;

	public bool isChedder4 = false;
	public bool isSwiss4 = false;
	public int chedder4Count = 0;
	public int swiss4Count = 0;
	public int gouda4Count = 0;
	public bool isGouda4 = false;

	public Transform cus1;
	public Transform cus2;
	public Transform cus3;
	public Transform cus4;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){

		// stops camera from getting destroyed
		if (!col.CompareTag("Player_Controller")) {


			if (Vector3.Distance (cus1.position, transform.position) < 7f) {

				if (col.CompareTag ("Chedder")) {
					isChedder = true;
					chedder1Counter += 1;
					Destroy (col.gameObject);
				} 
				if (col.CompareTag ("Swiss")) {
					isSwiss = true;
					swiss1Counter += 1;
					Destroy (col.gameObject);
				} 
				if (col.CompareTag ("Gouda")) {
					isGouda = true;
					gouda1Counter += 1;
					Destroy (col.gameObject);
				}
			} else {
				isGouda = false;
				isChedder = false;
				isSwiss = false;
				Destroy (col.gameObject);
			}

			if (Vector3.Distance (cus2.position, transform.position) < 7f) {

				if (col.CompareTag ("Chedder")) {
					chedder2Counter += 1;
					isChedder2 = true;

					Destroy (col.gameObject);
				} 
				if (col.CompareTag ("Swiss")) {
					isSwiss2 = true;
					swiss2Counter += 1;
					Destroy (col.gameObject);
				} 
				if (col.CompareTag ("Gouda")) {
					isGouda2 = true;
					gouda2Counter += 1;
					Destroy (col.gameObject);
				}
			} else {
				isGouda2 = false;
				isChedder2 = false;
				isSwiss2 = false;
				Destroy (col.gameObject);
			}




			if (Vector3.Distance (cus3.position, transform.position) < 7f) {

				if (col.CompareTag ("Chedder")) {
					isChedder3 = true;


					chedder3 += 1;
					Destroy (col.gameObject);
				} 
				//else if (col.CompareTag ("Chedder") && !isChedder3_Second && isChedder3) {
				//isChedder3_Second = true;
				//Destroy (col.gameObject);
				//}
				if (col.CompareTag ("Swiss")) {
					isSwiss3 = true;
					swiss3Counter += 1;
					Destroy (col.gameObject);
				} 
				if (col.CompareTag ("Gouda")) {
					isGouda3 = true;
					gouda3Counter += 1;
					Destroy (col.gameObject);
				}
			} else {
				isGouda3 = false;
				isChedder3 = false;
				isSwiss3 = false;
				Destroy (col.gameObject);
			}

			if (Vector3.Distance (cus4.position, transform.position) < 7f) {

				if (col.CompareTag ("Chedder")) {
					isChedder4 = true;
					chedder4Count += 1;

					Destroy (col.gameObject);
				} 
				if (col.CompareTag ("Swiss")) {
					isSwiss4 = true;
					swiss4Count += 1;
					Destroy (col.gameObject);
				} 
				if (col.CompareTag ("Gouda")) {
					isGouda4 = true;
					gouda4Count += 1;
					Destroy (col.gameObject);
				}
			} else {
				isGouda4 = false;
				isChedder4 = false;
				isSwiss4 = false;
				Destroy (col.gameObject);
			}

		}

	


	}
}
