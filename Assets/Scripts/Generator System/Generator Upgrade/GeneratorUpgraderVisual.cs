using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GeneratorUpgraderVisual : MonoBehaviour
{
    [SerializeField] protected ScoreController _scoreController;
    [SerializeField] protected GeneratorUpgrader _generatorUpgrader;

    [SerializeField] protected TextMeshProUGUI _scorePerSecText;

    [SerializeField] protected TextMeshProUGUI _multiplierText;
    [SerializeField] protected TextMeshProUGUI _multiplierUpgradeCostText;
    [SerializeField] protected Button _multiplierUpgradeButton;

    [SerializeField] protected TextMeshProUGUI _quantityText;
    [SerializeField] protected TextMeshProUGUI _quantityAddCostText;
    [SerializeField] protected Button _quantityAddButton;

    protected void Awake()
    {
        _multiplierUpgradeButton.onClick.AddListener(
            _generatorUpgrader.BuyMultiplierUpgrade);
        _quantityAddButton.onClick.AddListener(
            _generatorUpgrader.BuyAutoGenerator);
    }

    protected void Update()
    {
        HandleButtonInteractable();
        UpdateText();
    }

    protected virtual void HandleButtonInteractable()
    {
        _multiplierUpgradeButton.interactable = (
            _generatorUpgrader.MultiplierUpgradePrice <= _scoreController.CurrentScore) &&
            !_generatorUpgrader.HasMultiplierUpgraded;

        _quantityAddButton.interactable = (
            _generatorUpgrader.GeneratorPrice <= _scoreController.CurrentScore);
    }

    protected virtual void UpdateText()
    {
        float scorePerSec = _generatorUpgrader.GeneratorController.AutoScoreData.GetValue();
        _scorePerSecText.text = $"Score/s: {scorePerSec}";

        float multiplierValue = _generatorUpgrader.GeneratorController.ValueMultiplier;
        float upgradeMultiplierCost = _generatorUpgrader.MultiplierUpgradePrice;
        _multiplierText.text = $"Multiplier: {multiplierValue}";
        _multiplierUpgradeCostText.text = $"{upgradeMultiplierCost}";

        float generatorQuantity = _generatorUpgrader.GeneratorController.AutoScoreQuantity;
        float addGeneratorCost = _generatorUpgrader.GeneratorPrice;
        _quantityText.text = $"Quantity: {generatorQuantity}";
        _quantityAddCostText.text = $"{addGeneratorCost}";
    }
}
