using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour
{
    int _score;
    [SerializeField] View _view;

    private void Start()
    {
        _score = 0;
    }

    public void ScorePlus()
    {
        _score += 100;
        _view.ScoreChange(_score);
    }
}
