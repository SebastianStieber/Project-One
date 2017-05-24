using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

	PlayerMovement playerMovement;

	void Start () {
		playerMovement = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerMovement> ();
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			playerMovement.forward = !playerMovement.forward;
		}
	}
}
