using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedecineBox : MonoBehaviour
{

       private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            player.ApplyMedecine(); 
        }
        Die(); 
    }
   
    private void Die()
    {
        gameObject.SetActive(false); 
    }
}
