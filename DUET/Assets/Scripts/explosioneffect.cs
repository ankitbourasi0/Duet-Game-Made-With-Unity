using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosioneffect : MonoBehaviour
{
   ParticleSystem explosion;
   public static explosioneffect Instance;
     void Awake() {
        if (Instance == null)
        {
            Instance = this;
        }
     }
  void Start(){
       explosion = GetComponent<ParticleSystem>();

  }
  public void explosionPlay()
  {
             explosion.Play();
  }
   
}
