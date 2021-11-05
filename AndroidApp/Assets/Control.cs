using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public float speed = 8.0f;
    public float force = 1.0f;
    private Rigidbody2D body;
    
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {

        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);

        if(Input.GetKey(KeyCode.Space) && Mathf.Abs(body.velocity.y) <= force)
            body.velocity = new Vector2(body.velocity.x, speed);
    }

}
