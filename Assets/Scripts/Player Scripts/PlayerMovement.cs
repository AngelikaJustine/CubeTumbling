using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D myBody;

    public float moveSpeed = 2f;

    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.position.x < Screen.width / 2)
            {
                myBody.velocity = new Vector2(-moveSpeed, myBody.velocity.y);
            }
            if (touch.position.x > Screen.width / 2)
            {
                myBody.velocity = new Vector2(moveSpeed, myBody.velocity.y);
            }
        }
    } // move

    public void PlatformMove(float x)
    {
        myBody.velocity = new Vector2(x, myBody.velocity.y);
    }

} // class







































