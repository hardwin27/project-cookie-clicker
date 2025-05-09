using System;
using UnityEngine;

using ReadOnlyParameter;
public class ScoreController : MonoBehaviour
{
    [SerializeField] private ScoreModel _model;

    public float CurrentScore => _model.CurrentScore;

    private void Update()
    {
        HandleAutoScoring();
    }

    private void HandleAutoScoring()
    {
        float autoScoreRate = 0f;
        foreach (AutoScoreData autoScoreData in _model.AutoScoreDatas)
        {
            autoScoreRate += autoScoreData.GetValue();
        }

        _model.CurrentAutoScoreRate = autoScoreRate;
        AddScore(_model.CurrentAutoScoreRate * Time.deltaTime);
    }

    public void AddScore(float addedAmount)
    {
        _model.AddScore(addedAmount);
    }

    public void AddAutoScoreData(AutoScoreData autoScoreData)
    {
        _model.AddAutoScoreData(autoScoreData);
    }

    public void RemoveAutoScoreData(AutoScoreData autoScoreData)
    {
        _model.RemoveAutoScoreData(autoScoreData);
    }
}
