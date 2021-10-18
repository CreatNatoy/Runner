using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private Game _test; 

    private void Start()
    {
        _test = GameObject.FindObjectOfType<Game>();
    }

    private void Update()
    {
        transform.Translate(Vector3.left * _test.getSpeedGame * Time.deltaTime);
    }
   
    
}
