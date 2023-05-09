using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCube : MonoBehaviour
{
    [SerializeField] GameObject _cube;
    void Start()
    {
        for (int i = -50; i <= 50; i += 5)
        {
            Instantiate(_cube, new Vector3(0, 1, i), Quaternion.identity);
        }
    }

    void Update()
    {
        
    }
}
