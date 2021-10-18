using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : ObjectPool
{
    [SerializeField] private GameObject[] _enemyPrefabs;
    [SerializeField] private Transform[] _spawnPoints; 
    [SerializeField] private float _secondsBetweenSpawn;

    private float _elapserTime = 0;
    private float _changeTime = 0.05f;
    private float _limitTime = 0.8f;

    private float _numberChange = 2;
    private float _numberChange2 = 1.5f;

    private void Start()
    {
        Intialize(_enemyPrefabs);
      //  Time.timeScale = 2f; 
    }

    private void Update()
    {
        _elapserTime += Time.deltaTime; 

        if(_elapserTime >= _secondsBetweenSpawn)
        {
            if (TryGetObject(out GameObject enemy))
            {
                _elapserTime = 0;
                if (_secondsBetweenSpawn >= _limitTime) // time creat
                {
                    _secondsBetweenSpawn -= _changeTime;                                  
                }
                else
                {
                    _limitTime -= 0.05f; 
                    _changeTime /= _numberChange;
                    _numberChange++; 
                }
                int spawnPointNumber = Random.Range(0, _spawnPoints.Length);
                SetEnemy(enemy, _spawnPoints[spawnPointNumber].position);
            }
         
        }
    }

    private void SetEnemy(GameObject enemy, Vector3 spawnPoint)
    {
        enemy.SetActive(true);
        enemy.transform.position = spawnPoint;
    }
}
