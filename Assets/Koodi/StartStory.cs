using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartStory : MonoBehaviour
{
    public TMP_Text dialogueText;
    public Button continueBtn;

    private string[] dialogues;
    private int currenDialogueIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Luo dialogin vuorosanat
        dialogues = new string[]
        {
            "Welcome to Magic Forest!",
            "The story tells, you're a wizard living in a magical forest with your pet!",
            "You're doing your wizarding stuff in peace, until someone kidnaps your pet!",
            "You must save your pet! Onward!"
        };

        DisplayDialogue();
    }

    public void OnContinueClicked()
    {
        currenDialogueIndex++;

        // Tarkistaa onko kaikki dialogit näytetty
        if(currenDialogueIndex < dialogues.Length)
        {
            DisplayDialogue();
        } else
        {
            // Dialogien jälkeen lataa tasojen valinta
            SceneManager.LoadScene("TasonValinta");
        }
    }

    // Näyttää dialogit hakemalla lauseiden indeksit
   private void DisplayDialogue()
    {
        dialogueText.text = dialogues[currenDialogueIndex];
    }
}
