﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenAI : MonoBehaviour {

	public Rigidbody enemy;
	public float moveSpeed;
	public Transform target;
	public Transform chickenPen;
	public GameObject ScorManager;
	public int points = 10;
	// chicken runaway trigger
	void OnTriggerStay(Collider other){

		if(other.gameObject.name == "Player"){
			Debug.Log("Player has entered chickens trigger");

			transform.LookAt(target);

			transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);
		}
	}

	// Chicken random movement
	// Void

	// Chicken transport to pen void	
	void OnCollisionEnter(Collision other){
		if(other.gameObject.name == "Player"){
			// Add points to score
		 ScoreManager.AddPoints(points);
			// send chicken to chicken pen
			transform.position = chickenPen.position;
			transform.rotation = chickenPen.rotation;

		}
	}
}
