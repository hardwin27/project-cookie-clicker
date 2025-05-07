using System;
using UnityEngine;

using ReadOnlyParameter;
public class ScoreModel : MonoBehaviour
{
    [SerializeField, ReadOnly] private int _currentScore;

    public int CurrentScore => _currentScore;

    public Action<int> OnScoreUpdated;
    
    public void AddScore(int addedAmount)
    {
        _currentScore += addedAmount;
        OnScoreUpdated?.Invoke(CurrentScore);
    }
}
