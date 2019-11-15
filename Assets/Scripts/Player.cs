/* 
    ------------------- Code Monkey -------------------

    Thank you for downloading this package
    I hope you find it useful in your projects
    If you have any questions let me know
    Cheers!

               unitycodemonkey.com
    --------------------------------------------------
 */

using System;
using UnityEngine;

/*
 * Simple Jump
 * */
public class Player : MonoBehaviour {

    [SerializeField] private LayerMask platformsLayerMask;
    public GameObject weapon1;
    public GameObject weapon1bullet;
    public GameObject weapon2;
    public GameObject weapon2bullet;
    public GameObject weapon3;
    private Rigidbody2D rb;
    private PolygonCollider2D boxCollider2d;
    private int activeWeapon = 0;
    public float jumpVelocity = 100f;
    public float moveSpeed = 40f;
    public float upGravity = 12f;
    public float downGravity = 18f;
    private bool flipped = false;

    private void Awake() {
        rb = transform.GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<PolygonCollider2D>();

        weapon1.SetActive(true);
        weapon2.SetActive(false);
        weapon3.SetActive(false);

        activeWeapon = 1;
    }

    private void Update() {
        if (IsGrounded() && Input.GetKeyDown("w")) {
            rb.velocity = new Vector2(0f, jumpVelocity);
        }
        
        HandleMovement_FullMidAirControl();
        
        

        if(rb.velocity.y > 0)
        {
            Physics2D.gravity = new Vector2(0, -upGravity);
        }
        else
        {
            Physics2D.gravity = new Vector2(0, -downGravity);
        }

        if (Input.GetKeyDown("p"))
        {
            GameManager.moveToNextLevel();
        }


    


        //swaps weapons
        if (Input.GetKeyDown("1"))
        {
            weapon1.SetActive(true);
            weapon2.SetActive(false);
            weapon3.SetActive(false);

            activeWeapon = 1;
        }
        else if (Input.GetKeyDown("2"))
        {
            weapon1.SetActive(false);
            weapon2.SetActive(true);
            weapon3.SetActive(false);

            activeWeapon = 2;
        }
        else if (Input.GetKeyDown("3"))
        {
            weapon1.SetActive(false);
            weapon2.SetActive(false);
            weapon3.SetActive(true);

            activeWeapon = 3;
        }


        //weapon shooting code
        switch(activeWeapon)
        {
            case 1:
                if (Input.GetKeyDown("k"))
                {
                    GameObject ball = Instantiate(weapon1bullet, weapon1.transform.position, Quaternion.identity);
                    if (flipped)
                    {
                        ball.GetComponent<Rigidbody2D>().velocity = new Vector2(-300f, 0f);
                    }
                    else
                    {
                        ball.GetComponent<Rigidbody2D>().velocity = new Vector2(300f, 0f);
                    }
                    
                    Destroy(ball, 2f);
                }
                break;
            
            case 2:
                if (Input.GetKeyDown("k"))
                {
                    GameObject ball2 = Instantiate(weapon2bullet, weapon1.transform.position, Quaternion.identity);
                    if (flipped)
                    {
                        ball2.GetComponent<Rigidbody2D>().AddForce(new Vector2(-20000f, 20000f), ForceMode2D.Force);
                    }
                    else
                    {
                        ball2.GetComponent<Rigidbody2D>().AddForce(new Vector2(20000f, 20000f), ForceMode2D.Force);
                    }
                    Destroy(ball2, 2.5f);
                }
                break;
            case 3:
                /// weapon 3 code here
                break;
            
        }
  
    }

    private bool IsGrounded() {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, 1f, platformsLayerMask);
        return raycastHit2d.collider != null;
    }
    
    private void HandleMovement_FullMidAirControl() {
        if (Input.GetKey("a")) {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
            transform.localScale = new Vector3(-53.81509f, 60.55625f, 1f);
            flipped = true;
        } else {
            if (Input.GetKey("d")) {
                rb.velocity = new Vector2(+moveSpeed, rb.velocity.y);
                transform.localScale = new Vector3(53.81509f, 60.55625f, 1f);
                flipped = false;
            } else {
                // No keys pressed
                rb.velocity = new Vector2(0, rb.velocity.y);
            }
        }
    }
}