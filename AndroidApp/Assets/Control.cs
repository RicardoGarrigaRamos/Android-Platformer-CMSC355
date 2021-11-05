using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    Rigidbody2D body;
    

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
               
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = SimpleInput.GetAxis("Horizontal");
        body.velocity = new Vector2(moveX * speed, body.velocity.y);

        if(Input.GetKey(KeyCode.Space))
        {
            body.velocity = new Vector2(body.velocity.x, jumpForce);
        }        
    }

    public void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, jumpForce);
    }
}

