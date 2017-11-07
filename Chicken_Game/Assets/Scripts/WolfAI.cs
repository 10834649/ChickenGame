using System.Collections;
using UnityEngine;

public class WolfAI : MonoBehaviour {

	public Rigidbody enemy;
	public float moveSpeed;
	public Transform target;
	public int damage;

	// wolf advance trigger
	void OnTriggerStay(Collider other){

		if(other.gameObject.name == "Player"){

			Debug.Log("Player has entered wolfs trigger");

			transform.LookAt(target);

			transform.Translate(Vector0.back*moveSpeed*Time.deltatime);
		}
	}
	void OnCollisionEnter(Collision other){

		if(other.gameObject.name == "player"){
			PlayerHealth.TakeDamage(damage);
		}


		print("Attack!");
		var hit = other.gameObject;
		var health = hit.GetComponent<PlayerHealth>();

		if(health != null){
			health.TakeDamage(damage);
		}
	}
}