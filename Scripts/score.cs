using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int scoreValue = 0;
    private Text ScoreText;

    void Start()
    {
        ScoreText = GetComponent<Text>();
    }

    void Update()
    {
        ScoreText.text = "score: " + scoreValue;
    }

    void SaveScore()
    {
        
    }
}
