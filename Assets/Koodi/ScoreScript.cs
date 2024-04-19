using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text ScoreText;
    private int scoreNumber;
    // Start is called before the first frame update
    void Start()
    {
        scoreNumber = 0;
        ScoreText.text = "Score: " + scoreNumber;
    }

    private void OnTriggerEnter2D(Collider2D Enemy)
    {
        if(Enemy.tag == "Enemy")
        {
            scoreNumber += 10;
            ScoreText.text = "Score: " + scoreNumber;
            Debug.Log(scoreNumber);
        }
    }
}
