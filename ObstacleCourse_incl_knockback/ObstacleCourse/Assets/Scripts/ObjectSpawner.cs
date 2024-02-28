using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject _prefabToSpawn;
    public float _spawnInterval;

    private float _timer;

    private void Update()
    {
        _timer += Time.deltaTime;

        if(_timer > _spawnInterval)
        {
            Instantiate(_prefabToSpawn, transform.position, Quaternion.identity);
            _timer = 0;
        }
    }

}
