using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    [SerializeField]
    private float _rotationSpeed;

    private Rigidbody2D _rigidbody;
    private Vector2 _movementInput;
    private Vector2 _smoothedMovementInput;
    private Vector2 _movementInputSmoothVelocity;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
 
    }
    private void FixedUpdate()
    {
        SetPlayerVelocity();
        RotateInDirectionOfInput();

    }

    private void RotateInDirectionOfInput()
    {
        if (_movementInput != Vector2.zero)
        {
            float angle = Mathf.Atan2(_smoothedMovementInput.y, _smoothedMovementInput.x)
                          * Mathf.Rad2Deg   ;

            _rigidbody.MoveRotation(
                Mathf.LerpAngle(_rigidbody.rotation, angle, _rotationSpeed * Time.fixedDeltaTime)
            );
        }
    }


    private void SetPlayerVelocity()
    {
        _smoothedMovementInput = Vector2.SmoothDamp(
                    _smoothedMovementInput,
                    _movementInput,
                    ref _movementInputSmoothVelocity, 0.1f);
        _rigidbody.velocity = _smoothedMovementInput * _speed;
    }

    private void OnMove(InputValue inputValue)
    {
        _movementInput=inputValue.Get<Vector2>();
    }
}
