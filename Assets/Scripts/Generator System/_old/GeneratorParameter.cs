using ReadOnlyParameter;
using UnityEngine;

[System.Serializable]
public class GeneratorParameter
{
    [SerializeField] private string _paramName;
    [SerializeField] private string _paramDesc;
    [SerializeField] private float _paramInitValue;
    [SerializeField, ReadOnly] private float _paramValue;

    public float Value => _paramValue;

    public void ResetParameter()
    {
        _paramValue = _paramInitValue;
    }
}
