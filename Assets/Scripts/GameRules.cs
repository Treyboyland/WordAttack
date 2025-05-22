using System.Collections.Generic;
using UnityEngine;

public abstract class GameRules : ScriptableObject
{
    [SerializeField]
    protected WordDictionary wordDictionary;

    [SerializeField]
    protected GameEvent<string> onInvalid;

    [SerializeField]
    protected GameEvent<bool> onEndGame;

    public abstract void CheckSubmissions(string currentGuess, string wordToGuess, List<string> previousSubmissions, List<LetterSpot> letterSpots, out bool attemptUsed);
}

