using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageMove : MonoBehaviour
{
    public float jumpForce = 10;
    public float speed = 8;

    private int directionX;
    private bool canJump;
    private Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        directionX = 0;
        canJump = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space)) && canJump)
        {
            Debug.Log("Jump");
            body.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            canJump = false;
        }
        directionX = 0;
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Right");
            directionX = 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Left");
            directionX = -1;
        }
        
        body.velocity = new Vector2(speed * directionX, body.velocity.y);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("CollisionEnter2D");
        canJump=true;
    }
}
