// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class Victory : MonoBehaviour {

// 	public int winScore;
// 	public GameObject ScoreManager;

// 	int currentScore;
	
// 	public Text winText;

// 	// Use this for initialization
// 	void Start () {
// 		currentScore = ScoreManager.gameObject.GetComponent<ScoreManager>().scoreAmount;
// 		winText.GetComponent<Text>().enabled = false;
// 	}

	
// 	// Update is called once per frame
// 	void Update () {
// 		if(winScore == currentScore){
// 			print("Victory is yours! I submit!" + currentScore);
// 			winText.GetComponent<Text>().enabled = true;
// 		}
// 	}
// }
