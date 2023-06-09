﻿using UnityEngine;
using DG.Tweening;

public class PlayerMovement : MonoBehaviour, IMoveable
{
    #region Variables
    [SerializeField] private float _speed = 5f;

    private PlayerInput _playerInput;
    private Rigidbody _rigidbody;
    #endregion

    #region UnityMethods
    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move(_playerInput.GetDirection());
    }
    #endregion

    #region Methods
    public void Move(Vector2 direction)
    {
        Vector2 directionWithSpeed = direction * _speed;
        Vector3 newVelocity = new Vector3(directionWithSpeed.x, _rigidbody.velocity.y, directionWithSpeed.y);
        _rigidbody.velocity = newVelocity;

        if (direction.magnitude != 0)
        {
            float angle = Mathf.Atan2(direction.x, direction.y) * 180 / Mathf.PI;
            transform.rotation = Quaternion.Euler(transform.rotation.x, angle, transform.rotation.z);
        }
    }

    public void Freeze()
    {
        _rigidbody.isKinematic = true;
        _playerInput.FreezeInput();
    }

    public void Unfreeze()
    {
        _rigidbody.isKinematic = false;
        _playerInput.UnfreezeInput();
    }

    public void LookAt(Vector3 targetPosition)
    {
        Vector3 newTargetPos = new Vector3(targetPosition.x, transform.position.y, targetPosition.z);

        transform.DOLookAt(newTargetPos, .25f);
    }
    #endregion
}

