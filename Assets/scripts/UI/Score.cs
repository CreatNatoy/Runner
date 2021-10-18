using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text _textScore;
    [SerializeField] private float _timerScore;

    private float _currentTimerScore;
    private int _score = 0;

    public int MaxScore { get; private set; }

    private void Awake()
    {
        _textScore.text = _score.ToString();
        _currentTimerScore = _timerScore;
        if (!PlayerPrefs.HasKey("Score"))
            PlayerPrefs.SetInt("Score", 0);
        else
            MaxScore = PlayerPrefs.GetInt("Score"); 
    }

    private void Update()
    {
        _timerScore -= Time.deltaTime; 
        if(_timerScore <= 0)
        {
            _timerScore = _currentTimerScore;
            _score++;
            _textScore.text = _score.ToString(); 
            if(_score > MaxScore)
            {
                MaxScore = _score;
                PlayerPrefs.SetInt("Score", MaxScore);
            }
        }
    }
}
