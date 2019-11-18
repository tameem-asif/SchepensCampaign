using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textScript : MonoBehaviour {

	public Text finalPoints;
	
	// Update is called once per frame
	void Update () {
		finalPoints.text = "Final Points: " + GameManager.points.ToString();
	}
}
