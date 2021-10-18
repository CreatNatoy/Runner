using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private float _timer;
    [SerializeField] private float _speedGame;
    [SerializeField] private float _increaseGame; 

    private float _currentTimer;
    private float _speedEnemy; 

    public float getSpeedGame => _speedGame; 

    private void Start()
    {
        _currentTimer = _timer;
    }

    private void Update()
    {
        _timer -= Time.deltaTime; 
        if(_timer <= 0)
        {
            _speedGame += _increaseGame;
            _timer = _currentTimer; 
        }

    }
}
