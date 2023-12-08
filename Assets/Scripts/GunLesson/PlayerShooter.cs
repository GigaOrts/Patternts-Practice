using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    private IGun _currentGun;
    private IGun[] _guns;
    private int _currentIndex;

    private void Awake()
    {
        _guns = new IGun[]
        {
            new DefaultGun(),
            new InfiniteBulletsGun(),
            new TripleshotGun()
        };

        _currentGun = _guns[_currentIndex];
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            _currentGun.Shoot();
        else if (Input.GetMouseButtonDown(1))
            SwitchGun();
    }

    private void SwitchGun()
    {
        _currentIndex++;

        if (_currentIndex >= _guns.Length)
            _currentIndex = 0;

        _currentGun = _guns[_currentIndex];
    }
}
