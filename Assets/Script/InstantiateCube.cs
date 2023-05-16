using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCube : MonoBehaviour
{
    [SerializeField] GameObject _cube;
    [SerializeField] GameObject _player;
    int[] _random = {-7, 0, 7};
    float _timer;
    void Start()
    {
        //while(_ready)
    }

    void Update()
    {
        _timer += Time.deltaTime;
        if( _timer > 2 ) 
        {
            int lane = UnityEngine.Random.Range(0, 2);
            float playerPos = _player.transform.position.z;
            for(int i = 3; i <= UnityEngine.Random.Range(2,5); i += 2) 
            {
                Instantiate(_cube, new Vector3(_random[lane], 1, playerPos + i), Quaternion.identity);
            }
            _timer = 0;
        }
    }
}
