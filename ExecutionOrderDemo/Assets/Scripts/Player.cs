using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Enemy _enemy;

    private void Awake()
    {
        _enemy._rb.AddForce(Vector3.right * 10, ForceMode2D.Impulse);
    }

    void Start()
    {
    }

}
