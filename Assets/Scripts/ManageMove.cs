using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageMove : MonoBehaviour
{
    public float jumpForce = 10;
    public float speed = 20;

    private Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        int directionX = 0;
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space))
        {
            body.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.D))
            directionX = 1;
        if (Input.GetKeyDown(KeyCode.A))
            directionX = -1;
        body.velocity = new Vector2(speed * directionX, 0);

    }
}
