using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BootstrapBalls : MonoBehaviour
{
    [SerializeField] private BallSpawner _ballSpawner;
    [SerializeField] private ParticleSystem _winParticles;

    [SerializeField] private TMP_Dropdown _winConditionDropdown;
    [SerializeField] private TMP_Dropdown _ballColorDropdown;

    [SerializeField] private GameObject _menuLayer;
    [SerializeField] private GameObject _gameLayer;

    private Level _level;
    private List<Ball> _balls;

    private GameMode _chosenGameMode;
    private BallColor _chosenBallColor;

    private void Awake()
    {
        _winConditionDropdown.onValueChanged.AddListener(OnWinConditionChanged);
        _ballColorDropdown.onValueChanged.AddListener(OnBallColorChanged);
    }

    private void OnDisable()
    {
        _winConditionDropdown.onValueChanged.RemoveListener(OnWinConditionChanged);
        _ballColorDropdown.onValueChanged.RemoveListener(OnWinConditionChanged);
    }

    public void OnStartGame()
    {
        ResetBalls();
        _balls = _ballSpawner.SpawnBalls();
        InitializeWinCondition();
    }
    
    private void ResetBalls()
    {
        if (_balls == null)
            return;

        foreach (var ball in _balls)
        {
            Destroy(ball.gameObject);
        }
    }

    private void InitializeWinCondition()
    {
        var winConditionPicker = new WinConditionPicker(_balls, _chosenBallColor);
        WinCondition winCondition = winConditionPicker.GetWinCondition(_chosenGameMode);

        _level = new Level(winCondition);
        _level.Completed += ReturnToMenu;
    }

    private void ReturnToMenu()
    {
        Instantiate(_winParticles);
        _menuLayer.SetActive(true);
        _gameLayer.SetActive(false);
    }

    private void OnWinConditionChanged(int value)
    {
        _chosenGameMode = (GameMode)value;

        bool isActiveColorBallsBroken = _chosenGameMode == GameMode.ColorBallsBroken;
        _ballColorDropdown.gameObject.SetActive(isActiveColorBallsBroken);
    }

    private void OnBallColorChanged(int value)
    {
        _chosenBallColor = (BallColor)value;
    }
}
