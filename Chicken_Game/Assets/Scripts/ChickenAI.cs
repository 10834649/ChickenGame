using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenAI : MonoBehaviour {

	public Rigidbody enemy;
	public float moveSpeed;
	public Transform target;
	public Transform chickenPen;

	public int points = 10;
	// chicken runaway trigger
	void OnTriggerStay(Collider other){

		if(other.gameObject.name == "Player"){
			Debug.Log("Player has entered chickens trigger");

			transform.LookAt(target);

			transform.Translate(Vector3.back*moveSpeed*Time.deltatime);
		}
	}

	// Chicken random movement
	// Void

	// Chicken transport to pen void	
	void OnCollisionEnter(Collision other){
		if(other.gameObject.name == "Player"){
			// Add points to score
		GetComponent(ScorManager.AddPoints(points));
			// send chicken to chicken pen
			transform.position = chickenPen.position;
			transform.rotation = chickenPen.position;

		}
	}
}
