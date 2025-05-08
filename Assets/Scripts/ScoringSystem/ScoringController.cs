using UnityEngine;

public class ScoringController : MonoBehaviour
{
    [SerializeField] private ScoreController _scoreController;

    [SerializeField] private float _valuePerInput;
    [SerializeField] private bool _hasAutoScoring;
    [SerializeField] private float _autoScoringValue;

    private void Update()
    {
        HandleAutoScoring();
    }

    private void HandleAutoScoring()
    {
        if (!_hasAutoScoring)
        {
            return;
        }

        _scoreController.AddScore(_autoScoringValue * Time.deltaTime);
    }

    public void InputValue()
    {
        _scoreController.AddScore(_valuePerInput);
    }
}
