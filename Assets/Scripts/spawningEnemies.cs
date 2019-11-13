using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawningEnemies: MonoBehaviour {

    public Rigidbody2D enemy;
    public int dropRate = 5;
    private int timeInt = 0;
    private bool dropped = false;
	private Vector2 startPos;
	private Vector2 leftPos;
	private Vector2 rightPos;
	private float intervalPos = 100f;
	private float toMovePos = 10f;
	private bool rightReached = false;

    // Use this for initialization
    void Start ()
	{
		enemy = transform.GetComponent<Rigidbody2D>();
		startPos = enemy.transform.position;
		leftPos.x = startPos.x - intervalPos;
		rightPos.x = startPos.x + intervalPos;
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		if(!rightPos)
		{
			//FIX
		}
	}

	private void moveEnemyToRight(float f)
	{

	}

}
 