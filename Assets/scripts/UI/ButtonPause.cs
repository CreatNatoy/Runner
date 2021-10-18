using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPause : MonoBehaviour
{
    public void ActivePanel(GameObject panel)
    {
        panel.SetActive(true);
        Time.timeScale = 0; 
    }

    public void Continue(GameObject panel)
    {
        panel.SetActive(false);
        Time.timeScale = 1; 
    }
}
