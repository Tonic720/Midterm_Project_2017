using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Order_Crate : MonoBehaviour {

	public bool isChedder;
	public bool isSwiss;
	public bool isGouda;

	public bool isChedder2;
	public bool isSwiss2;
	public bool isGouda2;

	public bool isChedder3;
	public int chedder3 = 0;
	//public bool isChedder3_Second;
	public bool isSwiss3;
	public bool isGouda3;

	public bool isChedder4 = false;
	public bool isSwiss4 = false;
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


		if (Vector3.Distance (cus1.position, transform.position) < 8f || Vector3.Distance (cus2.position, transform.position) < 8f) {

			if (col.CompareTag ("Chedder")) {
				isChedder = true;
				Destroy (col.gameObject);
			} 
			if (col.CompareTag ("Swiss")) {
				isSwiss = true;
				Destroy (col.gameObject);
			} 
			if (col.CompareTag ("Gouda")) {
				isGouda = true;
				Destroy (col.gameObject);
			}
		} else {
			isGouda = false;
			isChedder = false;
			isSwiss = false;
			Destroy (col.gameObject);
		}

		if (Vector3.Distance (cus2.position, transform.position) < 8f) {

			if (col.CompareTag ("Chedder")) {
				isChedder2 = true;

				Destroy (col.gameObject);
			} 
			if (col.CompareTag ("Swiss")) {
				isSwiss2 = true;
				Destroy (col.gameObject);
			} 
			if (col.CompareTag ("Gouda")) {
				isGouda2 = true;
				Destroy (col.gameObject);
			}
		} else {
			isGouda2 = false;
			isChedder2 = false;
			isSwiss2 = false;
			Destroy (col.gameObject);
		}

		if (Vector3.Distance (cus2.position, transform.position) < 8f) {

			if (col.CompareTag ("Chedder")) {
				isChedder2 = true;

				Destroy (col.gameObject);
			} 
			if (col.CompareTag ("Swiss")) {
				isSwiss2 = true;
				Destroy (col.gameObject);
			} 
			if (col.CompareTag ("Gouda")) {
				isGouda2 = true;
				Destroy (col.gameObject);
			}
		} else {
			isGouda2 = false;
			isChedder2 = false;
			isSwiss2 = false;
			Destroy (col.gameObject);
		}

		if (Vector3.Distance (cus3.position, transform.position) < 8f) {

			if (col.CompareTag ("Chedder")) {
				isChedder3 = true;


				chedder3+= 1;
				Destroy (col.gameObject);
			} 
			//else if (col.CompareTag ("Chedder") && !isChedder3_Second && isChedder3) {
				//isChedder3_Second = true;
				//Destroy (col.gameObject);
			//}
			if (col.CompareTag ("Swiss")) {
				isSwiss3 = true;
				Destroy (col.gameObject);
			} 
			if (col.CompareTag ("Gouda")) {
				isGouda3 = true;
				Destroy (col.gameObject);
			}
		} else {
			isGouda3 = false;
			isChedder3 = false;
			isSwiss3 = false;
			Destroy (col.gameObject);
		}

		if (Vector3.Distance (cus4.position, transform.position) < 8f) {

			if (col.CompareTag ("Chedder")) {
				isChedder4 = true;
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
