using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreManager : MonoBehaviour {

	public static int score;
	public int scoreAmount = score;

	public int winScore;
	public Text text;

	public Text winText;
	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
			score = 0;

		winText.GetComponent<Text>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(score < 0)
			score = 0;

		text.text = " " + score;
			if(winScore == scoreAmount){
			print("Victory is yours! I submit!" + scoreAmount);
		winText.GetComponent<Text>().enabled = true;
	
	public static void AddPoints(int pointsToAdd){
				score += pointsToAdd;
			}
			}
	 void Reset()
	 {

			score = 0;
	}




	}


