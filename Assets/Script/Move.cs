using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Rigidbody _rb;
    bool isStop = false;
    [SerializeField] int _speed = 10;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Goal")
        {
            isStop = true;
            _rb.velocity = Vector3.zero;
        }
    }

    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!isStop) _rb.velocity = transform.forward * _speed;
    }
}