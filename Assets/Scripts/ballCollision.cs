using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballCollision : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.tag == "obstacle")
		{
			Destroy(gameObject);
		}
	}
}
