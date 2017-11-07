using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class WanderScriptComponents : MonoBehaviour {



// // position
// public float posX = .5f;
// public float posY;
// public float posZ;

public Vector3 pos;


// // Rotate
// public float rotX;
// public float rotY;
// public float rotZ;
// public float rotW;

public Quaternion rot;


// // Scale
// public float x = 1f;
// public float y = 1f;
// public float z = 1f;


public Vector3 scale;

void Update (){
// 	transform.position = new Vector3(posX,posY,posZ);
// 	transform.rotation = new Quaternion(rotX,rotY,rotZ,rotW);
// 	transform.localScale = new Vector3(x,y,z);
	// Transform is pos, rotation, and scale

	transform.position = pos;
	transform.rotation = rot;
	transform.localScale = scale;
}

// A vector is a point in space
// it has coordinates (X,Y,Z)
// Spawn points are vectors
// transform dot position to vector 
// Vector 3 means 3 axis (3D)
// movement is in degrees (rotation)
// Quaternian is a reference for rotation
// 
	
}
