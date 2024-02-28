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
        public GameObject _poopPref;
        public float _moveSpeed = 5;
        public float _flingForce = 500;
        public float _flingCooldown = 2;

        private Rigidbody2D _rb;
        private AudioSource _audioSource;

        private float _flingTimer;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
            _audioSource = GetComponent<AudioSource>();

            _flingTimer = _flingCooldown;
        }


        private void Update()
        {
            _flingTimer += Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space) && _flingTimer >= _flingCooldown)
            {
                _audioSource.Play();
                _flingTimer = 0;

                Vector3 spawnPos = transform.position + new Vector3(0, 0.5f, 0);
                GameObject newPoop = Instantiate(_poopPref, spawnPos, Quaternion.identity);

                Rigidbody2D poopRb = newPoop.GetComponent<Rigidbody2D>();
                poopRb.AddForce(new Vector2(0, _flingForce));
            }

        }








        void FixedUpdate()
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");
            Vector3 moveInput = new Vector3(horizontalInput, verticalInput, 0);

            Vector3 newPos = transform.position + moveInput * Time.deltaTime * _moveSpeed;
            _rb.MovePosition(newPos);

        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Coin")
            {
                SceneManager.LoadScene("Level2");
            }
        }
    }
}