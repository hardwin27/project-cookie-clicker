using System;
using System.Collections.Generic;
using UnityEngine;

using ReadOnlyParameter;

public class ScoreModel : MonoBehaviour
{
    [SerializeField, ReadOnly] private float _currentScore;

    [SerializeField] private List<AutoScoreData> _autoScoresDatas = new List<AutoScoreData>();
    [SerializeField, ReadOnly] private float _currentAutoScoreRate = 0f;

    public float CurrentScore => _currentScore;
    public float CurrentAutoScoreRate { get => _currentAutoScoreRate; set => _currentAutoScoreRate = value; }
    public List<AutoScoreData> AutoScoreDatas => _autoScoresDatas;

    public Action<float> OnScoreUpdated;

    public void AddScore(float addedAmount)
    {
        _currentScore += addedAmount;
        OnScoreUpdated?.Invoke(CurrentScore);
    }

    public void AddAutoScoreData(AutoScoreData autoScoreData)
    {
        _autoScoresDatas.Add(autoScoreData);
    }

    public void RemoveAutoScoreData(AutoScoreData autoScoreData)
    {
        _autoScoresDatas.Remove(autoScoreData);
    }
}
