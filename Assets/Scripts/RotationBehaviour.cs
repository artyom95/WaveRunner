using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class RotationBehaviour : MonoBehaviour
{
    [SerializeField] 
    private float _rotation;
    private  void Update()
    {
        transform.Rotate(0f,0f, _rotation );
    }
}

 