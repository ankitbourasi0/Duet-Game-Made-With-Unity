using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetectionBalls : MonoBehaviour
{

    ParticleSystem explosionFx;

    void Start(){
        explosionFx = transform.GetChild(0).GetComponent<ParticleSystem>();
    }
    void OnCollisionEnter2D (Collision2D other){
        if(other.collider.CompareTag("Obstacles")){
            GameManger.Instance.isGameOver = true;
            explosionFx.Play();
        PlayerMovement.Instance.Restart();
        }
    }
}
