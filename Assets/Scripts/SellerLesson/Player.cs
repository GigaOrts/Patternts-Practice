using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public event Action<int> ReputationChanged;

    public void SetReputation(int value)
    {
        if (value < PlayerConfig.LowReputation || value > PlayerConfig.HighReputation)
            throw new ArgumentOutOfRangeException(nameof(value));

        ReputationChanged?.Invoke(value);
    }
}