using UnityEngine;

public class PlayerBuyer : MonoBehaviour
{
    [SerializeField, Range(0, 2)] private int _reputation;

    public int Reputation => _reputation;
}