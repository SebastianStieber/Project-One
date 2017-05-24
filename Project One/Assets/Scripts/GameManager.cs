using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	public int score;

	public void Awake(){
		DontDestroyOnLoad (gameObject);
	}

	void Start () {
		if (instance == null) {
			instance = new GameManager();
		}
	}

	void Update () {
		
	}
}
