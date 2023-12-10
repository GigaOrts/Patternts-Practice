using UnityEngine;

public class GunLessonBootstrap : MonoBehaviour
{
    private const int RightMouse = 1;

    [SerializeField] private Shooter _shooter;

    private GunSwitcher _gunSwitcher;

    private void Awake()
    {
        _gunSwitcher = new GunSwitcher();
        _shooter.SetGun(_gunSwitcher.GetNextGun());
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(RightMouse))
            _shooter.SetGun(_gunSwitcher.GetNextGun());
    }
}
