using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private float _delaySpawn = 2f;
    [SerializeField] private GameObject _enemy;

    private Transform[] _spawnPoints;

    void Awake()
    {
        _spawnPoints = GetComponentsInChildren<Transform>();
        StartCoroutine(SpawnerCoroutine());
    }

    IEnumerator SpawnerCoroutine()
    {
        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            Instantiate(_enemy, _spawnPoints[i]);
            yield return new WaitForSeconds(_delaySpawn);
        }
    }
}
