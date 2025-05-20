using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    private TMP_Text _text;
    private int _score;
    public static ScoreText Instance{get; private set;}
    private void Awake()
    {
        _text = GetComponent<TMP_Text>();
        Instance = this;
    }

    public void AddScore(int value)
    {
        _score += value;
        _text.SetText(_score.ToString());
    }
}
