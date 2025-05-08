using System;
using UnityEngine;

using ReadOnlyParameter;
public class ScoreController : MonoBehaviour
{
    [SerializeField] private ScoreModel _model;

    public void AddScore(float addedAmount)
    {
        _model.AddScore(addedAmount);
    }
}
