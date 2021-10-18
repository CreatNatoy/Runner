using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//обязуеться то что у компоненка будет PlayerMover
[RequireComponent(typeof(PlayerMover))]
public class PlayerInput : MonoBehaviour
{
    [SerializeField] private GameObject _laycast;
    [SerializeField] private Transform _pointLaycast;
    [SerializeField] private SpawnerLaycast _spawnerLaycast;
    [SerializeField] private Music _music;

    private PlayerMover _mover;


    private void Start()
    {
        _mover = GetComponent<PlayerMover>();
    }

    private void Update()
    {
        /*
        if(Input.GetKeyDown(KeyCode.W))
        {
            _mover.TryMoveUp();
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            _mover.TryMoveDown(); 
        }
        */
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _spawnerLaycast.SetLaycast();
            _music.PlayShotSound();
        }
    }

    public void Shot()
    {
        _spawnerLaycast.SetLaycast();
        _music.PlayShotSound();
    }
}
