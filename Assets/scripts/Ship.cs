using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ship : MonoBehaviour
{
    [SerializeField] private int _health; 
    [SerializeField] private Player _player;
    [SerializeField] private Text _text10;

    private int _maxHealth;

    private void Start()
    {
        _maxHealth = _health;
        _text10.text = _health.ToString(); 
    }

    public void ApplyDamage(int damage)
    {
        _health -= damage;
        _text10.text = _health.ToString();
        if (_health <= 0 )
        {
            GameOver();
        }
    }

    public void ApplyMedecine()
    {
        if (_health < _maxHealth)
            _health++; 
    }

    public void GameOver()
    {
        _player.Die(); 
    }
}
