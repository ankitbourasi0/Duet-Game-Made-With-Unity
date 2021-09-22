using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetectionBalls : MonoBehaviour
{
    void OnCollisionEnter2D (Collision2D other){
        if(other.collider.CompareTag("Obstacles")){
            GameManger.Instance.isGameOver = true;
        PlayerMovement.Instance.Restart();
        }
    }
}
