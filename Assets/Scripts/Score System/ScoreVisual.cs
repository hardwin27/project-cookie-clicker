using UnityEngine;
using TMPro;

public class ScoreVisual : MonoBehaviour
{
    [SerializeField] private ScoreModel _model;

    [SerializeField] private TextMeshProUGUI _scoreText;

    private void OnEnable()
    {
        if (_model != null)
        {
            _model.OnScoreUpdated += UpdateScore;
        }
    }

    private void OnDisable()
    {
        if (_model != null)
        {
            _model.OnScoreUpdated -= UpdateScore;
        }
    }

    private void UpdateScore(float score)
    {
        _scoreText.text = $"{Mathf.RoundToInt(score)}";        
    }
}
