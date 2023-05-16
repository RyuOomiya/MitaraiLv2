using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class View : MonoBehaviour
{
    [SerializeField] Text _scoreText;

    public void ScoreChange(int score)
    {
        _scoreText.text = score.ToString();
    }
}
