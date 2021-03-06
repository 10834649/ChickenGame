﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolfhealth : MonoBehaviour {

	public int currentHealth;
	public int maxHealth = 3;
	public Transform spawnPoint;
	public int points;

	void start(){
		currentHealth = maxHealth;
	}

	public void TakeDamage(int amount){
		currentHealth -= amount;
		if(currentHealth <= 0){
			currentHealth = 0;
			print("wolf is dead!");
			ScoreManager.AddPoints(points);
			transform.position = spawnPoint.position;
			transform.rotation = spawnPoint.rotation;
			currentHealth = maxHealth;
		}
	}
}
