using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public float _spawnCD = 2;
    public GameObject _objToSpawn;

    private float _spawnTimer;

    void Update()
    {
        _spawnTimer += Time.deltaTime;
        if(_spawnTimer > _spawnCD)
        {
            _spawnTimer = 0;
            Instantiate(_objToSpawn, transform.position, Quaternion.identity);
        }
    }
}
