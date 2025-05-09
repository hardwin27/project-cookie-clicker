using UnityEngine;

public class ScoringController : MonoBehaviour
{
    [SerializeField] private ScoreController _scoreController;

    [SerializeField] private string _scoreId;
    [SerializeField] private float _valuePerInput;
    [SerializeField] private bool _isInitiallyAutoScoring;
    [SerializeField] private float _autoScoringValue;

    [SerializeField] private AutoScoreData _autoScoreData;

    private void Awake()
    {
        _autoScoreData = new AutoScoreData(_scoreId, _autoScoringValue, _isInitiallyAutoScoring);
    }

    private void OnEnable()
    {
        _scoreController.AddAutoScoreData(_autoScoreData);
    }

    private void OnDisable()
    {
        _scoreController.RemoveAutoScoreData(_autoScoreData);
    }

    public void InputValue()
    {
        _scoreController.AddScore(_valuePerInput);
    }
}
