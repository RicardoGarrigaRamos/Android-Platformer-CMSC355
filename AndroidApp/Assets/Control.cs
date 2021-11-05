using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Control : MonoBehaviour
{
    public float speed = 10;
    public float jumpForce = 10;
    private BoxCollider2D boxCollider2d;
    private Rigidbody2D body;
    [SerializeField] private LayerMask platformLayerMask;
    

    // Start is called before the first frame update
    void Start()
    {
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
        body = transform.GetComponent<Rigidbody2D>();
               
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = SimpleInput.GetAxis("Horizontal");
        body.velocity = new Vector2(moveX * speed, body.velocity.y);

        if(IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            body.velocity = new Vector2(body.velocity.x, jumpForce);
        }        
    }

    public void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, jumpForce);
    }

    private bool IsGrounded()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, .1f, platformLayerMask);
        Debug.Log(raycastHit2d.collider);
        return raycastHit2d.collider != null;
    }
}

