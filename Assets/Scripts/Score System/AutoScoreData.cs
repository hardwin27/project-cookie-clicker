using UnityEngine;

using ReadOnlyParameter;
using UnityEngine.Experimental.GlobalIllumination;

[System.Serializable]
public class AutoScoreData
{
    [SerializeField, ReadOnly] private string _scoreId;
    [SerializeField, ReadOnly] private float _autoScoreValue;
    [SerializeField, ReadOnly] private GeneratorParameter _autoScoringQuantity;
    [SerializeField, ReadOnly] private GeneratorParameter _valueMultiplier;

    public string ScoreId => _scoreId;

    public AutoScoreData(string scoreId, float autoScoreValue, GeneratorParameter autoScoringQuantity, 
        GeneratorParameter valueMultiplier) 
    { 
        _scoreId = scoreId;
        _autoScoreValue = autoScoreValue;
        _autoScoringQuantity = autoScoringQuantity;
        _valueMultiplier = valueMultiplier;
    }

    public float GetValue()
    {
        return _autoScoreValue * _autoScoringQuantity.Value * _valueMultiplier.Value;
    }
}
