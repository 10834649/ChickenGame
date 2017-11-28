using UnityEngine.UI;
using System.Collections;
using UnityEngine;

public class WolfAI : MonoBehaviour {

	public Rigidbody enemy;
	public float moveSpeed;
	public Transform target;
	public int damage;
	public GameObject pcHealth;

	// wolf advance trigger
	void OnTriggerStay(Collider other){

		if(other.gameObject.name == "Player"){

			Debug.Log("Player has entered wolfs trigger");

			transform.LookAt(target);

			transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);
		}
	}
	void OnCollisionEnter(Collision other){

		if(other.gameObject.name == "Player"){
		var hit = other.gameObject;
		var health = hit.GetComponent<PlayerHealth>();

		if(pcHealth != null){
			print("Attack!");
			pcHealth.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);
			}
		}
	}
}