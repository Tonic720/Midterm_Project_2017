using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Ice : MonoBehaviour {
	public Text hintText;
	public Transform player;
	bool didPlayerWin = false;



	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (player.position, transform.position) < 10f) {
			hintText.text = "You found the ice, you're saved. Press [SPACE] to collect it";
			if (Input.GetKey (KeyCode.Space)) {
				didPlayerWin = true;
			} else if (didPlayerWin) {
				hintText.text = "         YOU WIN!!!";
			}

		}
		

	}


}
