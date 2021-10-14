using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorBallPrefab : MonoBehaviour
{
    
  
    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("BlueBall"))
        {
            clone();
        }
   }
   void clone()
   {
       
       Destroy(gameObject,0.25f);
     explosioneffect.Instance.explosionPlay();

   }
}
