using System;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [Range(BallSpawnerConfig.MinBallsCount, BallSpawnerConfig.MaxBallsCount)]
    [SerializeField] private int _ballsCount;

    [SerializeField] private Ball[] _ballPrefabs;
    [SerializeField] private Transform _spawnPoints;

    private Transform[] _points;

    private void Awake()
    {
        InitializePoints(_spawnPoints);
    }

    public List<Ball> SpawnBalls()
    {
        var balls = new List<Ball>();

        for (int i = 0; i < _ballsCount; i++)
        {
            int randomOffset = UnityEngine.Random.Range(0, 1);
            
            int pointIndex = (i + randomOffset) % _points.Length;
            int ballIndex = i % _ballPrefabs.Length;

            Ball ball = Instantiate(_ballPrefabs[ballIndex], _points[pointIndex].position, Quaternion.identity, _spawnPoints);
            balls.Add(ball);
        }

        return balls;
    }

    private void InitializePoints(Transform spawnPoints)
    {
        _points = new Transform[_spawnPoints.childCount];

        for (int i = 0; i < spawnPoints.childCount; i++)
        {
            _points[i] = spawnPoints.GetChild(i);
        }
    }
}
