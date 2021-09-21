using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float rotatingSpeed;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        MovePlayerUpward();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey (KeyCode.LeftArrow)){
            RotatingLeft();
        }else if(Input.GetKey (KeyCode.RightArrow)){
            RotatingRight();
        }

        if(Input.GetKeyUp (KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow)){
            rb.angularVelocity = 0f;
        }
    }
    void MovePlayerUpward(){
        rb.velocity = Vector2.up * speed;
    }
    void RotatingLeft(){
        rb.angularVelocity = rotatingSpeed;
    }
    void RotatingRight(){
        rb.angularVelocity = -rotatingSpeed;
    }
}
