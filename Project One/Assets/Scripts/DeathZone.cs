using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class DeathZone : MonoBehaviour {

	public float y = 3;

	Player player;

	void Start () {
		player = Object.FindObjectOfType<Player> ();
	}

	void Update () {
		transform.position = new Vector3(player.transform.position.x, -y, player.transform.position.z);
	}

	void OnTriggerEnter(Collider collider){
		if (collider.tag == "Player") {
			player.Reset ();

			Object.FindObjectOfType<BlockManager> ().Reset ();

			GameManager.instance.score = 0;
		}
	}

	void OnDrawGizmos(){
		Gizmos.color = Color.red;
		Gizmos.DrawWireCube (transform.position, transform.localScale);
	}
}
