﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorManager : MonoBehaviour {

	public static int score;

	public Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
			score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(score < 0)
			score = 0;

		text.text = " " + score;
	}
 public void AddPoints(int points){
				score += points;
			}
	 void Reset()
	 {

			score = 0;
	}




	}


