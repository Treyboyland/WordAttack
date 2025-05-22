using TMPro;
using UnityEngine;

public class LetterSpot : MonoBehaviour
{
    [SerializeField]
    TMP_Text letter;

    [SerializeField]
    SpriteRenderer background;

    [SerializeField]
    Color correctSpot;

    [SerializeField]
    Color incorrectSpot;

    [SerializeField]
    Color neutralColor;

    public string Text
    {
        get
        {
            return letter.text;
        }
        set
        {
            letter.text = value;
        }
    }

    void SetColor(Color c)
    {
        background.color = c;
    }

    public void SetBackgroundNeutral()
    {
        SetColor(neutralColor);
    }

    public void SetBackgroundCorrect()
    {
        SetColor(correctSpot);
    }

    public void SetBackgroundWrongSpot()
    {
        SetColor(incorrectSpot);
    }
}
