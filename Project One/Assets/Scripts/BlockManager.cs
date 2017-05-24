using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour {

	public GameObject blockPrefab;

	GameObject lastBlock;

	List<GameObject> blocks = new List<GameObject>();

	public int puffer = 2;
	public int y;

	int currentPuffer;

	void Start () {
		currentPuffer = puffer;
	}

	void Update () {
		if (!lastBlock)
			GenerateBlock ();
	}

	public void GenerateBlock(){
		GameObject block = null;
		block = Instantiate (blockPrefab);

		if (!lastBlock) {
			block.transform.position = Vector3.zero;
		} else {
			int c = Random.Range (0, 2);
			Vector3 direction = c == 0 ? Vector3.forward : Vector3.left;

			if (currentPuffer > 0) {
				currentPuffer--;
				direction = Vector3.forward;
			}

			Vector3 position = lastBlock.transform.position + Vector3.Scale(lastBlock.transform.localScale / 2, direction) + Vector3.Scale(block.transform.localScale / 2, direction);
			position.y = -y;
			block.transform.LookAt (block.transform.position + direction);

			block.GetComponent<Block> ().SpawnBlock (position);

			GameManager.instance.score++;
		}

		lastBlock = block;
		blocks.Insert (0, block);
	}

	public void Reset() {
		foreach (GameObject block in blocks) {
			Destroy(block);
		}

		blocks.Clear();
		lastBlock = null;

		currentPuffer = puffer;
	}
}
