using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public Rigidbody projectile;
	public Transform ShootPoint;
	public int shootSpeed;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){
			Rigidbody clone;

			clone = (Rigidbody)Instantiate(projectile, ShootPoint.position, projectile.rotation);

			clone.velocity = ShootPoint.TransformDirection (Vector3.forward*shootSpeed);
		}
		
	}
}
