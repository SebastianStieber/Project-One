using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public Vector3 spawn;

	void Start () {
		transform.position = spawn;
	}

	void Update () {
	}

	public void Reset(){
		GetComponent<Rigidbody> ().velocity = Vector3.zero;
		transform.position = spawn;

		GetComponent<PlayerMovement> ().forward = true;
	}
}
