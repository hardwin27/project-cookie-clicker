using UnityEngine;

using ReadOnlyParameter;
using UnityEngine.Experimental.GlobalIllumination;

[System.Serializable]
public class AutoScoreData
{
    [SerializeField, ReadOnly] private string _scoreId;
    [SerializeField, ReadOnly] private bool _isAutoEnabled;
    [SerializeField, ReadOnly] private float _autoScoreValue;

    public string ScoreId => _scoreId;
    public bool IsAutoEnabled => _isAutoEnabled;
    public float AutoScoreValue => _autoScoreValue;

    public AutoScoreData(string scoreId, float autoScoreValue, bool isAutoEnabled) 
    { 
        _scoreId = scoreId;
        _autoScoreValue = autoScoreValue;
        _isAutoEnabled = isAutoEnabled;
    }

    public void AddAutoScoreValue(float addedValue)
    {
        _autoScoreValue += addedValue;
    }

    public void EnableAutoScore(bool isEnabled)
    {
        _isAutoEnabled = isEnabled;
    }
}
