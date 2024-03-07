using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float _moveSpeed = 2;

    private Rigidbody2D _rb;
    private SqrlyCode.PlayerController _player;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _player = FindObjectOfType<SqrlyCode.PlayerController>();
    }

    private void FixedUpdate()
    {
        if (_player != null)
        {
            Vector3 dir = (_player.transform.position - transform.position).normalized;

            Vector3 newPos = transform.position + dir * Time.deltaTime * _moveSpeed;
            _rb.MovePosition(newPos);
        }
    }
}
