using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalscore : MonoBehaviour
{
    public Text scoreText;
    private static int scoreValue;
    public Text Feedback;
   
    void Start(){
    }

    void Update()
    {
        scoreText.text = "Want to go again?";

        if (scoreValue == 500000)
        {
            Feedback.text = "damn you good!";
        }

        else if (scoreValue <= 4999 && scoreValue >= 3000)
        {
            Feedback.text = "hey, that pretty giid";
        }

        else if (scoreValue <= 2999 && scoreValue >= 1000)
        {
            Feedback.text = "is not that bad";
        }

        else if (scoreValue <= 999 && scoreValue >= 0)
        {
            Feedback.text = "pratice make perfect";
        }
    }
    // fail script...
}
