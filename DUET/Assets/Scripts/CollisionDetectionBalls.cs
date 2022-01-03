using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetectionBalls : MonoBehaviour
{

    ParticleSystem explosionFx;
    int ballIndex;
    void Start(){
        explosionFx = transform.GetChild(0).GetComponent<ParticleSystem>();
        ballIndex = transform.position.x > 0 ? 0 : 1;
    }
    void OnCollisionEnter2D (Collision2D other){
        if(other.collider.CompareTag("Obstacles")){
            GameManger.Instance.isGameOver = true;
            explosionFx.Play();
            Handheld.Vibrate();
          
            Splatters.Instance.AddSplatter(other.transform, other.contacts[0].point, ballIndex);
        PlayerMovement.Instance.Restart();
        }
    }
}
