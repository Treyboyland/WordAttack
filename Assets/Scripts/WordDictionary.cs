using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "WordDictionary", menuName = "Scriptable Objects/WordDictionary")]
public class WordDictionary : ScriptableObject
{
    [SerializeField]
    TextAsset dictionaryObject;

    [SerializeField]
    TextAsset badWordsObject;

    bool parsed = false;

    public bool Parsed => parsed;

    Dictionary<string, string> wordDictionary = new Dictionary<string, string>();

    public void ParseDictionary()
    {
        //TODO: Figure this out
    }

    public HashSet<string> GetWordsOfLength(int length)
    {
        return wordDictionary.Keys.Where(x => x.Length == length).ToHashSet();
    }

    public bool Contains(string word)
    {
        return wordDictionary.ContainsKey(word);
    }
}
