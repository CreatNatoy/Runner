using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScreen : MonoBehaviour
{
    [SerializeField] private GameObject _startScreen;
    [SerializeField] private Text _maxScore; 

    private void Awake()
    {
        Time.timeScale = 0;
        if (!PlayerPrefs.HasKey("Score"))
            PlayerPrefs.SetInt("Score", 0);
        _maxScore.text = PlayerPrefs.GetInt("Score").ToString(); 
    }

    public void ButtonStart()
    {
        Time.timeScale = 1;
        _startScreen.SetActive(false);
        SceneManager.LoadScene(1);

    }

    public void ButtonExit()
    {
        Application.Quit();
    }
}
