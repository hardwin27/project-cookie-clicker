using UnityEngine;
using UnityEngine.UI;

public class ClickerInput : MonoBehaviour
{
    [SerializeField] private GeneratorController _generatorController;
    [SerializeField] private Button _clickerButton;

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
        _generatorController.InputValue();
    }
}
