using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speed = 5f;
	public float smoothRotation = 3f;

	public bool forward = true;

	void Start () {
		
	}

	void Update () {
		Vector3 direction = forward ? Vector3.forward : Vector3.left;
		transform.position = transform.position + direction * speed * Time.deltaTime;

		transform.rotation = Quaternion.Lerp (transform.rotation, Quaternion.LookRotation(direction), smoothRotation * Time.deltaTime);
	}
}
