using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private float _delaySpawn = 2f;
    [SerializeField] private Enemy _enemy;

    private WaitForSeconds _waitForSeconds;
    private Transform[] _spawnPoints;

    private void Awake()
    {
        _waitForSeconds = new WaitForSeconds(_delaySpawn);
        _spawnPoints = GetComponentsInChildren<Transform>();
        StartCoroutine(SpawnerCoroutine());
    }

    private IEnumerator SpawnerCoroutine()
    {
        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            Instantiate(_enemy, _spawnPoints[i]);
            yield return _waitForSeconds;
        }
    }
}
