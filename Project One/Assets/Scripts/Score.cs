﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	Text text;
	
	void Start () {
		text = GetComponent<Text> ();
	}

	void Update () {
		text.text = GameManager.instance.score + "";
	}
}
