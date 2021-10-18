using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laycast : MonoBehaviour
{
    private Game _test;

    private void Start()
    {
        _test = GameObject.FindObjectOfType<Game>();
    }

    private void Update()
    {
        transform.Translate(Vector3.right * _test.getSpeedGame * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Die();
    }

    private void Die()
    {
        gameObject.SetActive(false);  
    }
}
