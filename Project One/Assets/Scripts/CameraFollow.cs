using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CameraFollow : MonoBehaviour {

	public GameObject target;
	public Vector3 distance;

	void Start () {
		target = GameObject.FindGameObjectWithTag ("Player");
	}

	void Update () {
		transform.position = target.transform.position + distance;
		transform.LookAt (target.transform.position);
	}


}
