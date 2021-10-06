using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class SlidingObstacles : MonoBehaviour
{
    [SerializeField] float slidingDuration;
    [SerializeField] float slidingDistance;
     
    // Start is called before the first frame update
    void Start()
    {
        transform
            .DOLocalMoveX( slidingDistance ,slidingDuration)
            .SetLoops(-1 , LoopType.Yoyo)
            .SetEase(Ease.InOutBack);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
