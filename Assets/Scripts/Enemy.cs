using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;

    public GameObject GetEnemyPrefab()
    {
        return _enemyPrefab;
    }
}
