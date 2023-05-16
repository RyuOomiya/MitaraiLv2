using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    [SerializeField] Rigidbody _rb;
    bool _isStop = false;
    bool _left;
    bool _right;
    [SerializeField] int _speed = 10;
    float _movementX;
    InputAction _moveAction;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Goal")
        {
            _isStop = true;
            _rb.velocity = Vector3.zero;
        }

        if (collision.gameObject.name == "Left") _left = true;
        if (collision.gameObject.name == "Right") _right = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Left") _left = false;
        if (collision.gameObject.name == "Right") _right = false;
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        _movementX = movementVector.x;

        if (_movementX <= -1 && !_left)
        {
            if (_right) transform.position = new Vector3(0, 1, transform.position.z);
            else transform.position = new Vector3(-7, 1, transform.position.z);
        }
        if (_movementX >= 1 && !_right)
        {
            if (_left) transform.position = new Vector3(0, 1, transform.position.z);
            else transform.position = new Vector3(7, 1, transform.position.z);
        }
    }

    void Awake()
    {
        _moveAction = GetComponent<PlayerInput>().currentActionMap["Move"];
        _rb = GetComponent<Rigidbody>();

        _left = false;
        _right = false;
    }

    private void Update()
    {
        //if (gameObject.transform.position.x >= 9.5f) transform.position = new Vector3(9.4f, 1, transform.position.z);
        //if (gameObject.transform.position.x <= -9.5f) transform.position = new Vector3(-9.4f, 1, transform.position.z);

        if (!_isStop)
        {
            _rb.velocity = new Vector3(0, 0, _speed);
        }
    }
}