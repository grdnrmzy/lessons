using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    public float _speed;

   
    public Vector3 _direction;
    public float Speed => _speed;

    #region MonoBehaviour

    private void OnValidate()
    {
        if (_speed < 0)
            _speed = 0;
    }

    public void TurnLeft()
    {

    }

    public void TurnRight()
    {

    }

    public void Move()
    {

    }

    #endregion
}