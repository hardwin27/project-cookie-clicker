using System.Collections.Generic;
using UnityEngine;
using ReadOnlyParameter;

public class GeneratorController : MonoBehaviour
{
    [SerializeField] protected ScoreController _scoreController;

    [SerializeField] protected string _scoreId;
    [SerializeField] protected float _valuePerInput;
    [SerializeField] protected float _autoScoringValue;

    [SerializeField] protected GeneratorParameter _autoScoreQuantity;
    [SerializeField] protected GeneratorParameter _valueMultiplier;

    [SerializeField] protected AutoScoreData _autoScoreData;

    protected Dictionary<string, GeneratorParameter> _parameters = new Dictionary<string, GeneratorParameter>();

    public Dictionary<string, GeneratorParameter> Parameters => _parameters;

    protected void Awake()
    {
        InitializeParamters();

        _autoScoreData = new AutoScoreData(_scoreId, _autoScoringValue,
            _autoScoreQuantity, _valueMultiplier);
    }

    protected void OnEnable()
    {
        _scoreController.AddAutoScoreData(_autoScoreData);
    }

    protected void OnDisable()
    {
        _scoreController.RemoveAutoScoreData(_autoScoreData);
    }

    protected virtual void InitializeParamters()
    {
        _autoScoreQuantity.ResetParameter();
        _valueMultiplier.ResetParameter();

        _parameters.Add("autoScoreQuantity", _autoScoreQuantity);
        _parameters.Add("_valueMultiplier", _valueMultiplier);
    }

    public void InputValue()
    {
        _scoreController.AddScore(_valuePerInput * _valueMultiplier.Value);
    }
}
