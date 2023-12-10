public class GunSwitcher
{
    private readonly Gun[] _guns;
    private int _currentIndex = -1;

    public GunSwitcher()
    {
        _guns = new Gun[]
          {
            new DefaultGun(),
            new InfiniteBulletsGun(),
            new TripleshotGun()
          };
    }

    public Gun GetNextGun()
    {
        _currentIndex++;

        if (_currentIndex >= _guns.Length)
            _currentIndex = 0;

        return _guns[_currentIndex];
    }
}
