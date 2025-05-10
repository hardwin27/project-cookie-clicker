using UnityEngine;
using ReadOnlyParameter;

public class GeneratorUpgrader : MonoBehaviour
{
    [SerializeField] protected GeneratorController _generatorController;
    [SerializeField] protected ScoreController _scoreController; // might be temporary implementation

    [SerializeField] protected float _initialGeneratorPrice;
    [SerializeField] protected float _generatorPriceIncrease;
    [SerializeField, ReadOnly] protected float _currentGeneratorPrice;

    [SerializeField] private float _multiplierUpgradePrice;
    [SerializeField, ReadOnly] private bool _hasMultiplierUpgraded = false;

    public float GeneratorPrice => _currentGeneratorPrice;
    public float MultiplierUpgradePrice => _multiplierUpgradePrice;
    public GeneratorController GeneratorController => _generatorController;
    public bool HasMultiplierUpgraded => _hasMultiplierUpgraded;

    protected void Start()
    {
        UpdateGeneratorPrice();
    }

    protected void UpdateGeneratorPrice()
    {
        _currentGeneratorPrice = _initialGeneratorPrice +
            (_generatorPriceIncrease * _generatorController.AutoScoreQuantity);
    }

    public void BuyAutoGenerator()
    {
        Debug.Log($"BuyAutoGenerator");

        if (_scoreController.CurrentScore >= GeneratorPrice)
        {
            _scoreController.AddScore(-GeneratorPrice);
            _generatorController.AddAutoScoreQuantity(1f);
            UpdateGeneratorPrice();
        }
    }

    public void BuyMultiplierUpgrade()
    {
        Debug.Log($"BuyMultiplierUpgrade");

        if (!_hasMultiplierUpgraded)
        {
            if (_scoreController.CurrentScore >= _multiplierUpgradePrice)
            {
                _scoreController.AddScore(-_multiplierUpgradePrice);
                _generatorController.AddValueMultiplier(1);
                _hasMultiplierUpgraded = true;
            }
        }
    }
}
