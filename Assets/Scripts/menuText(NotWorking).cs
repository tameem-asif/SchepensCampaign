using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuText : MonoBehaviour {

	public Text finalPoints;
	void Update () {
		finalPoints.text = "Final Points: " + GameManager.points.ToString();
	}
}
