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
    private Rigidbody2D rb;
    private BoxCollider2D boxCollider2d;
    public float jumpVelocity = 100f;
    public float moveSpeed = 40f;
    public float upGravity = 12f;
    public float downGravity = 18f;

    private void Awake() {
        rb = transform.GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
    }

    private void Update() {
        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space)) {
            rb.velocity = Vector2.up * jumpVelocity;
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
  
    }

    private bool IsGrounded() {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, 1f, platformsLayerMask);
        return raycastHit2d.collider != null;
    }
    
    private void HandleMovement_FullMidAirControl() {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
        } else {
            if (Input.GetKey(KeyCode.RightArrow)) {
                rb.velocity = new Vector2(+moveSpeed, rb.velocity.y);
            } else {
                // No keys pressed
                rb.velocity = new Vector2(0, rb.velocity.y);
            }
        }
    }
}