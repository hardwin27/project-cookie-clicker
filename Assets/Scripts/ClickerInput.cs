using UnityEngine;
using UnityEngine.UI;

public class ClickerInput : MonoBehaviour
{
    [SerializeField] private ScoreController _scoreController;

    [SerializeField] private Button _clickerButton;
    [SerializeField] private int _clickerValue;

    private void OnEnable()
    {
        _clickerButton.onClick.AddListener(HandleClickerClickeed);
    }

    private void OnDisable()
    {
        _clickerButton.onClick.RemoveListener(HandleClickerClickeed);
    }

    private void HandleClickerClickeed()
    {
        _scoreController.AddScore(_clickerValue);
    }
}
