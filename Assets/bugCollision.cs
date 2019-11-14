using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bugCollision : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.tag == "bullet")
		{
			Destroy(col.gameObject);
			Destroy(gameObject);
		}
	}
}
