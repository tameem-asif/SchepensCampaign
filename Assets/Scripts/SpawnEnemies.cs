using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour {

    public Rigidbody2D enemy;
    public int dropRate = 25;
    private int timeInt = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(Time.time);
        timeInt = (int) Time.time;
        Debug.Log(timeInt);
       // 


     if (timeInt % dropRate == 0)
        {
            Debug.Log("dropped");
            Rigidbody2D fallingObjInstance = Instantiate(enemy, new Vector3(Random.Range(-70.0f, 70.0f), Random.Range(25.0f, 800.0f), Random.Range(-1.0f, 34.0f)), transform.rotation) as Rigidbody;
        }
        
    }
}
