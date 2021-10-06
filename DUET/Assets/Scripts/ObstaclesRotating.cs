using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObstaclesRotating : MonoBehaviour
{

    [SerializeField] float rotatingDuration;
    // Start is called before the first frame update
    void Start()
    {
        transform
            .DORotate(new Vector3(0,0,1f), rotatingDuration)
            .SetLoops(-1, LoopType.Incremental);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
