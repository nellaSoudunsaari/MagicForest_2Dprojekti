using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text ScoreText;
    public int scoreNumber;
     

    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = "Score: " + scoreNumber;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Saa pisteit‰ mik‰li tuhoaa jotain
        if(collision.tag == "Enemy")
        {
            scoreNumber += 10;
            ScoreText.text = "Score: " + scoreNumber;
        }

        if (collision.tag == "Boss")
        {
            scoreNumber += 1000;
            ScoreText.text = "Score: " + scoreNumber;
        }

        // Menett‰‰ pisteit‰ mik‰li kuolee
        if (collision.tag == "Obstacle")
        {
            scoreNumber -= 10;
            ScoreText.text = "Score: " + scoreNumber;
        }
    }
}
