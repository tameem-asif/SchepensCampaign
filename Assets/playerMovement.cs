using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    Rigidbody2D rb;
    public float moveSpeed = 10;
    public float jump = 10;

    public GameObject weapon1;
    public GameObject weapon2;
    public GameObject weapon3;


    private float startYpos;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
        
        startYpos = transform.position.y;

        weapon1.GetComponent<SpriteRenderer>().enabled = true;
        weapon2.GetComponent<SpriteRenderer>().enabled = false;
        weapon3.GetComponent<SpriteRenderer>().enabled = false;
	}
	

	void Update () 
    {
        float h = Input.GetAxisRaw("Horizontal");
        rb.velocity = Vector2.right * h * moveSpeed;
        
        if (Input.GetKeyDown("w") && transform.position.y <= startYpos)
        {
            rb.AddForce(new Vector2(0f, jump), ForceMode2D.Impulse);
        }
        
        if (Input.GetKeyDown("1"))
        {
            weapon1.GetComponent<SpriteRenderer>().enabled = true;
            weapon2.GetComponent<SpriteRenderer>().enabled = false;
            weapon3.GetComponent<SpriteRenderer>().enabled = false;
        }
        else if (Input.GetKeyDown("2"))
        {
            weapon1.GetComponent<SpriteRenderer>().enabled = false;
            weapon2.GetComponent<SpriteRenderer>().enabled = true;
            weapon3.GetComponent<SpriteRenderer>().enabled = false;
        }
        else if (Input.GetKeyDown("3"))
        {
            weapon1.GetComponent<SpriteRenderer>().enabled = false;
            weapon2.GetComponent<SpriteRenderer>().enabled = false;
            weapon3.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
