using UnityEngine;

using ReadOnlyParameter;
using UnityEngine.Experimental.GlobalIllumination;

[System.Serializable]
public class AutoScoreData
{
    [SerializeField, ReadOnly] private string _scoreId;
    [SerializeField, ReadOnly] private bool _isAutoEnabled;
    [SerializeField, ReadOnly] private float _autoScoreValue;
    [SerializeField, ReadOnly] private float _autoScoringQuantity;
    [SerializeField, ReadOnly] private float _valueMultiplier;

    public string ScoreId => _scoreId;
    public bool IsAutoEnabled => _isAutoEnabled;

    public AutoScoreData(string scoreId, float autoScoreValue, bool isAutoEnabled, 
        float autoScoringQuantity, float valueMultiplier) 
    { 
        _scoreId = scoreId;
        _autoScoreValue = autoScoreValue;
        _isAutoEnabled = isAutoEnabled;
        _autoScoringQuantity = autoScoringQuantity;
        _valueMultiplier = valueMultiplier;
    }

    public float GetValue()
    {
        return _autoScoreValue * _autoScoringQuantity * _valueMultiplier;
    }

    public void AddAutoScoringQuantity(float addedValue)
    {
        _autoScoringQuantity += addedValue;
    }

    public void ValueMultiplier(float addedValue) 
    {
        _valueMultiplier += addedValue;
    }

    public void EnableAutoScore(bool isEnabled)
    {
        _isAutoEnabled = isEnabled;
    }
}
