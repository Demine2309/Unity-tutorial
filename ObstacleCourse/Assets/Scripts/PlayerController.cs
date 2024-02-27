using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject _poopPref;
    public float _moveSpeed = 5;
    public float _flingForce = 500;

    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 spawnPos = transform.position + new Vector3(0, 0.5f, 0);
            GameObject newPoop = Instantiate(_poopPref, spawnPosc, Quaternion.identity);
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

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
