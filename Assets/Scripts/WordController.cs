using System.Collections.Generic;
using UnityEngine;

public class WordController : ObjectPool<LetterSpot>
{
    string wordToGuess;
    public string WordToGuess
    {
        get => wordToGuess;
        set
        {
            wordToGuess = value;
        }
    }

    string currentGuess;


    List<LetterSpot> usedLetters = new List<LetterSpot>();

    void SetupGame()
    {
        DisableAll();
        for (int i = 0; i < wordToGuess.Length; i++)
        {
            var letter = GetObject();
            letter.Text = "";
            letter.SetBackgroundNeutral();
            letter.gameObject.SetActive(true);

        }
    }

    public void UpdateLetters(string text)
    {
        currentGuess = text;
        text.ToUpper();
        for (int i = 0; i < usedLetters.Count; i++)
        {
            usedLetters[i].Text = i < text.Length ? "" + text[i] : "";
        }
    }

    public void CheckSubmission()
    {

    }
}
