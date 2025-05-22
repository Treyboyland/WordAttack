using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameRulesWordGuess", menuName = "Scriptable Objects/GameRulesWordGuess")]
public class GameRulesWordGuess : GameRules
{
    public override void CheckSubmissions(string currentGuess, string wordToGuess, List<string> previousSubmissions, List<LetterSpot> letterSpots, out bool attemptUsed)
    {
        if (currentGuess.Length != wordToGuess.Length)
        {
            onInvalid.Invoke($"You must fill all {wordToGuess.Length} spaces");
            attemptUsed = false;
            return;
        }
        if (!wordDictionary.Contains(currentGuess))
        {
            onInvalid.Invoke("Word not in dictionary");
            attemptUsed = false;
            return;
        }

        attemptUsed = true;

        for (int i = 0; i < currentGuess.Length; i++)
        {
            Action a;
            if (currentGuess[i] == wordToGuess[i])
            {
                a = letterSpots[i].SetBackgroundCorrect;
            }
            else if (wordToGuess.Contains(currentGuess[i]))
            {
                a = letterSpots[i].SetBackgroundWrongSpot;
            }
            else
            {
                a = letterSpots[i].SetBackgroundNeutral;
            }
            a.Invoke();
        }

        if (wordToGuess == currentGuess)
        {
            onEndGame.Invoke(true);
        }
    }
}
