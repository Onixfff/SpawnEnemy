using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private float _delaySpawn = 2f;
    [SerializeField] private Enemy _enemy;
    [SerializeField] private GameObject _enemyPrefab;

    private WaitForSeconds _waitForSeconds;
    private Transform[] _spawnPoints;

    void Awake()
    {
        _enemyPrefab = _enemy.GetEnemyPrefab();
        _waitForSeconds = new WaitForSeconds(_delaySpawn);
        _spawnPoints = GetComponentsInChildren<Transform>();
        StartCoroutine(SpawnerCoroutine());
    }

    IEnumerator SpawnerCoroutine()
    {
        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            Instantiate(_enemyPrefab, _spawnPoints[i]);
            yield return _waitForSeconds;
        }
    }
}
