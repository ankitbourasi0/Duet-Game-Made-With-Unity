using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splatters : MonoBehaviour
{

    
    [SerializeField] Color[] colors = new Color[2];
    [SerializeField]  GameObject splatterPrefab;
    [SerializeField]   Sprite[] splatterSprites;

    public static Splatters Instance;
    void Awake() {
        if (Instance == null)
        {
            Instance = this;
        }
    }


   public void AddSplatter(Transform obstacle, Vector3 posi,int colorIndex){
      GameObject splater =  Instantiate(splatterPrefab,
       posi, 
       Quaternion.Euler(new Vector3(0f,0f, Random.Range(-320f ,320f)))
      ,obstacle);
      SpriteRenderer sr = splater.GetComponent<SpriteRenderer>();
      sr.color = colors[colorIndex];
      sr.sprite = splatterSprites[Random.Range(0,splatterSprites.Length)];
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
