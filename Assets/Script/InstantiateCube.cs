using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCube : MonoBehaviour
{
    [SerializeField] GameObject _cube;

    int _itemPos = -50;
    int[] _random = {-7, 0, 7};
    bool _ready;

    void Start()
    {
        while (!_ready)
        {
            int lane = UnityEngine.Random.Range(0, 3);
            for (int i = 0; i < 3; i++)
            {
                Instantiate(_cube, new Vector3(_random[lane], 1, _itemPos + 3), Quaternion.identity);
                _itemPos += 3;
            }
            if (_itemPos >= 40) _ready = true;
        }
    }
}
