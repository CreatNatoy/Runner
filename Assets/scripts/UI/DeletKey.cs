using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletKey : MonoBehaviour
{
    public void DeleteKey()
    {
        PlayerPrefs.DeleteAll(); 
    }
}
