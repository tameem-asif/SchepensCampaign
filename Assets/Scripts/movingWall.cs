using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingWall : MonoBehaviour {

	Rigidbody2D rb;

	public float rotateSpeed = 1;
	
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Vector3 rotation = transform.rotation.eulerAngles;
		rotation.z += rotateSpeed;
		transform.rotation = Quaternion.Euler(rotation);
	}
}
