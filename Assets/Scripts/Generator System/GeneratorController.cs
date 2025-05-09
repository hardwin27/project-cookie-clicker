using System.Collections.Generic;
using UnityEngine;
using ReadOnlyParameter;

public class GeneratorController : MonoBehaviour
{
    [SerializeField] protected ScoreController _scoreController;

    [SerializeField] protected string _scoreId;
    [SerializeField] protected float _valuePerInput;
    [SerializeField] protected float _autoScoringValue;

    [SerializeField] protected float _initAutoScoreQuantity;
    [SerializeField] protected float _initValueMultiplier;

    [SerializeField] protected AutoScoreData _autoScoreData;

    public float AutoScoreQuantity => _autoScoreData == null ? 0 : _autoScoreData.AutoScoreQuantity;
    public float ValueMultiplier => _autoScoreData == null ? 0 : _autoScoreData.ValueMultiplier;


    protected void Awake()
    {
        _autoScoreData = new AutoScoreData(_scoreId, _autoScoringValue,
            _initAutoScoreQuantity, _initValueMultiplier);
    }

    protected void OnEnable()
    {
        _scoreController.AddAutoScoreData(_autoScoreData);
    }

    protected void OnDisable()
    {
        _scoreController.RemoveAutoScoreData(_autoScoreData);
    }

    public void InputValue()
    {
        _scoreController.AddScore(_valuePerInput * ValueMultiplier);
    }

    public void AddAutoScoreQuantity(float addedValue)
    {
        _autoScoreData.AddAutoScoreQuantity(addedValue);
    }

    public void AddValueMultiplier(float addedValue) 
    { 
        _autoScoreData.AddValueMultiplier(addedValue);
    }
}
