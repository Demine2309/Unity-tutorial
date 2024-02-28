using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poop : MonoBehaviour
{
    public float _knockBackForce = 8;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        if (collision.gameObject.tag == "Enemy")
        {
            Rigidbody2D otherRb = collision.gameObject.GetComponent<Rigidbody2D>();
            Vector3 knockbackDir = collision.transform.position - transform.position;
            otherRb.AddForce(knockbackDir.normalized * _knockBackForce, ForceMode2D.Impulse);
        }
    }
}
