using System;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private BallColor _color;

    public event Action Clicked;

    public BallColor CurrentBallColor => _color;

    public void Deactivate()
    {
        gameObject.SetActive(false);
        
        Clicked?.Invoke();
    }
}