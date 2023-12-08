using System.Collections.Generic;
using UnityEngine;

public class WinHandler : MonoBehaviour
{
    [SerializeField, Range(0, 1)] private int _winConditionIndex;
    [SerializeField] private BallColor _ballColorForWin;
    [SerializeField] private ParticleSystem _winParticles;
    [SerializeField] private List<Ball> _balls;

    private IWinCondition _currentWinCondition;
    private IWinCondition[] _winConditions;
    private bool _isGameFinished;

    private void Awake()
    {
        _winConditions = new IWinCondition[]
        {
            new AllBallsBrokenWinCondition(_balls),
            new OneColorBallsBrokenWinCondition(_balls, _ballColorForWin)
        };

        _currentWinCondition = _winConditions[_winConditionIndex];
    }

    void Update()
    {
        if (_isGameFinished)
            return;

        if (_currentWinCondition.IsPlayerWin())
        {
            Instantiate(_winParticles);
            _isGameFinished = true;
        }
    }
}
