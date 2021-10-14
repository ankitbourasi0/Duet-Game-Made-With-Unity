using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerMovement : MonoBehaviour
{   

    [SerializeField] CircleCollider2D redballcollider;
   [SerializeField] CircleCollider2D blueballcollider;


    public static PlayerMovement Instance;

    void Awake(){
        if(Instance == null){
            Instance = this;
        }
    }

    public float speed; //Variable for upward speed
    public float rotatingSpeed; //variable for rotating speed
    Rigidbody2D rb;//variable from this can access unity's RigidBody features of Physics
    Vector3 startPosition;
    Camera cam;
    float touchPosition;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        startPosition = transform.position;
        rb = GetComponent<Rigidbody2D>();
        MovePlayerUpward();
    }

    // Update is called once per frame
    void Update()
    {
        //Mobile Inputs
        if(!GameManger.Instance.isGameOver){
              if(Input.GetMouseButtonDown(0))
                touchPosition = cam.ScreenToWorldPoint(Input.mousePosition).x;

            if(Input.GetMouseButton(0)){
                if(touchPosition > 0.01f)
                    // Debug.Log("right ");
                    RotatingRight();
                else
                    // Debug.Log("left");
                    RotatingLeft();
            }else
                rb.angularVelocity = 0f; 
            
        }


        if(Input.GetKey (KeyCode.LeftArrow)){
            RotatingLeft();
        }else if(Input.GetKey (KeyCode.RightArrow)){
            RotatingRight();
        }

        if(Input.GetKeyUp (KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow)){
            rb.angularVelocity = 0f;
        }
        if(Input.GetMouseButtonDown(0)){
         
        }
      

    }
    public void MovePlayerUpward(){
        rb.velocity = Vector2.up * speed;//moving player in upward direction
    }
    void RotatingLeft(){
        rb.angularVelocity = rotatingSpeed; //player rotate in anti-clockwise direction
    }
    void RotatingRight(){
        rb.angularVelocity = -rotatingSpeed; //player rotate in clock-wise direction
    }
    public void Restart(){
        //when balls get collides with obstacles their collider component get disable
        //all motion gets stop.
        redballcollider.enabled = false; 
        blueballcollider.enabled = false;
        rb.angularVelocity = 0f;
        rb.velocity = Vector2.zero;


    //back to start position
    transform
        .DORotate(Vector3.zero , 1f)//balls position get reset
        .SetDelay(1f)
        .SetEase(Ease.InOutBack);
    
    transform
        .DOMove(startPosition,1f)
        .SetDelay(1f)
        .SetEase(Ease.OutFlash)
        .OnComplete(()=>{
           redballcollider.enabled = true; 
        blueballcollider.enabled = true;

        GameManger.Instance.isGameOver = false;
        MovePlayerUpward();  
        });
    }
}
