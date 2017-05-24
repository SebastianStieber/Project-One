using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

	BlockManager blockManager;

	bool hasGeneratedNextBlock = false;
	bool spawned = false;

	public float animationTime = 1f;
	float animatedTime = 0;

	Vector3 spawnPosition;
	Vector3 targetPosition;

	void Start () {
		blockManager = GameObject.FindGameObjectWithTag ("World").GetComponent<BlockManager> ();
	}

	void Update () {
		if (spawned && animatedTime <= animationTime) {
			animatedTime += Time.deltaTime / animationTime;
			if (animatedTime > animationTime)
				animatedTime = animationTime;

			float t = animatedTime / animationTime;
			t = Mathf.Sin (t * Mathf.PI * .5f);
			
			transform.position = Vector3.Lerp (spawnPosition, targetPosition, t);
		}
	}

	void OnTriggerEnter(Collider collider){
		if (collider.tag == "Player" && !hasGeneratedNextBlock) {
			hasGeneratedNextBlock = true;
			blockManager.GenerateBlock ();
		}
	}

	public void SpawnBlock(Vector3 position){
		spawned = true;

		transform.position = position;
		spawnPosition = position;
		targetPosition = position;
		targetPosition.y = 0;
	}
}
