using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerLaycast : ObjectPool
{
    [SerializeField] private GameObject _laycastPrefab;
    [SerializeField] private Transform _spawnPoint;

    private void Start()
    {
        Intialize(_laycastPrefab); 
    }

    public void SetLaycast()
    {
        if(TryGetObject(out GameObject laycast))
        {
                 laycast.SetActive(true);
                 laycast.transform.position = _spawnPoint.position;
        } 

    }
}
