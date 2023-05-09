using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    [SerializeField] Rigidbody _rb;
    bool _isStop = false;
    [SerializeField] int _speed = 10;
    float _movementX;
    float _moveLangeX;
    InputAction _moveAction;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Goal")
        {
            _isStop = true;
            _rb.velocity = Vector3.zero;
        }
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        // x²•ûŒü‚Ì“ü—Í’l‚ğ•Ï”‚É‘ã“ü
        _movementX = movementVector.x;
    }

    void Awake()
    {
        _moveAction = GetComponent<PlayerInput>().currentActionMap["Move"];
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //_moveLangeX = Mathf.Clamp(_movementX * _speed, -9.5f, 9.5f);

        
    }

    private void Update()
    {
        if (gameObject.transform.position.x >= 9.5f) transform.position = new Vector3(9.4f, 1, transform.position.z);
        if (gameObject.transform.position.x <= -9.5f) transform.position = new Vector3(-9.4f, 1, transform.position.z);

        if (!_isStop)
        {
            _rb.velocity = new Vector3(_movementX * _speed, 0, _speed);
        }
    }
}