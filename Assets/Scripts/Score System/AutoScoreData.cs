using UnityEngine;

using ReadOnlyParameter;
using UnityEngine.Experimental.GlobalIllumination;

[System.Serializable]
public class AutoScoreData
{
    [SerializeField, ReadOnly] private string _scoreId;
    [SerializeField, ReadOnly] private float _autoScoreValue;
    [SerializeField, ReadOnly] private float _autoScoreQuantity;
    [SerializeField, ReadOnly] private float _valueMultiplier;

    public string ScoreId => _scoreId;

    public float AutoScoreQuantity => _autoScoreQuantity;
    public float ValueMultiplier => _valueMultiplier;

    public AutoScoreData(string scoreId, float autoScoreValue, float autoScoreQuantity,
        float valueMultiplier) 
    { 
        _scoreId = scoreId;
        _autoScoreValue = autoScoreValue;
        _autoScoreQuantity = autoScoreQuantity;
        _valueMultiplier = valueMultiplier;
    }

    public void AddAutoScoreQuantity(float addedValue)
    {
        _autoScoreQuantity += addedValue;
    }

    public void AddValueMultiplier(float addedValue)
    {
        _valueMultiplier += addedValue;
    }

    public float GetValue()
    {
        return _autoScoreValue * _autoScoreQuantity * _valueMultiplier;
    }
}
