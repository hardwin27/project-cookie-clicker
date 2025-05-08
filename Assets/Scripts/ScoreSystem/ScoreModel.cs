using System;
using UnityEngine;

using ReadOnlyParameter;
public class ScoreModel : MonoBehaviour
{
    [SerializeField, ReadOnly] private float _currentScore;

    public float CurrentScore => _currentScore;

    public Action<float> OnScoreUpdated;
    
    public void AddScore(float addedAmount)
    {
        _currentScore += addedAmount;
        OnScoreUpdated?.Invoke(CurrentScore);
    }
}
