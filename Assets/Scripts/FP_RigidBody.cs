using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FP_RigidBody : MonoBehaviour {

	Vector3 inputVector;
	Rigidbody rb;

	public float mouseSense = 400f;
	public float forcePower = 100f;
	public float gravity = -0.5f;
	public float cameraDegree = 60;

	float mouseY;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	// use this for input and rendering 
	void Update () {
		// this handles keybaord movement 

		inputVector.x = Input.GetAxis ("Horizontal");

		inputVector.y = gravity;

		inputVector.z = Input.GetAxis ("Vertical");


		// Mouse look
		transform.Rotate(0f, Input.GetAxis("Mouse X") * Time.deltaTime * mouseSense, 0f); 
		mouseY -= Input.GetAxis ("Mouse Y") * Time.deltaTime * mouseSense;
		mouseY = Mathf.Clamp (mouseY, -60f, 60f);
		Camera.main.transform.localEulerAngles = new Vector3 (mouseY, 0f, 0f);


		//hide mouse
		if(Input.GetMouseButtonDown(0)){ // 0 = left 1 = right 2 = middle 
			Cursor.lockState= CursorLockMode.Locked;
			Cursor.visible = false;

		}
	}
	// runs on a fixed interval on the physics engine 
	// ALways put physics code in fixed update 
	void FixedUpdate(){

		// Manual way of movement 
		// also see transform.TransformDirection();
		Vector3 worldVector = transform.right * inputVector.x + transform.forward * inputVector.z + transform.up * inputVector.y;

		// Addforce is good for movement that is not walking 
		//rb.AddForce (worldVector * forcePower, ForceMode.VelocityChange); // where we apply the force 

		// Set velocity directly 

		rb.velocity = worldVector * forcePower;


	}
}
