using System.Collections;
using UnityEngine;

public class WolfAI : MonoBehaviour {

	public Rigidbody enemy;
	public float moveSpeed;
	public Transform target;

	// chicken runaway trigger
	void OnTriggerStay(Collider other){

		if(other.gameObject.name == "Player"){
			Debug.Log("Player has entered wolfs trigger");

			transform.LookAt(target);

			transform.Translate(Vector0.back*-moveSpeed*Time.deltatime);
		}
	}
}
