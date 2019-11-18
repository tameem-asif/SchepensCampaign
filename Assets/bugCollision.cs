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
			GameManager.addPoints(75);
			Player.numBugs --;
		}

		if (col.gameObject.tag == "bullet2")
		{
			Destroy(col.gameObject);
			Destroy(gameObject);
			GameManager.addPoints(150);
			Player.numBugs --;
		}

		if(col.gameObject.tag == "foot")
		{
			Debug.Log("I am trying to kill it");
			Destroy(gameObject);
			GameManager.addPoints(50);
			Player.numBugs --;
		}

		if(col.gameObject.tag == "Player")
		{
			Destroy(gameObject);
			GameManager.decreaseLive();
			Player.numBugs --;
		}
	}
}
