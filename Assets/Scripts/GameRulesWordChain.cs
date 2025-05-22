using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameRulesWordChain", menuName = "Scriptable Objects/GameRulesWordChain")]
public class GameRulesWordChain : GameRules
{
    public override void CheckSubmissions(string currentGuess, string wordToGuess, List<string> previousSubmissions, List<LetterSpot> letterSpots, out bool attemptUsed)
    {
        attemptUsed = true;
        if (!wordDictionary.Contains(currentGuess))
        {

        }
        if (previousSubmissions.Contains(currentGuess))
        {
            onEndGame.Invoke(false);
        }
    }
}
