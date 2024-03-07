using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

namespace SqrlyCode
{
    public class PlayerController : MonoBehaviour
    {
        public Transform _enemy;
        public float _moveSpeed = 5;

        private Rigidbody2D _rb;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        void FixedUpdate()
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");
            Vector3 moveInput = new Vector3(horizontalInput, verticalInput, 0);

            Vector3 newPos = transform.position + moveInput * Time.deltaTime * _moveSpeed;
            _rb.MovePosition(newPos);

        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Enemy")
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
        }
    }
}