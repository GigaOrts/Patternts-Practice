using UnityEngine;

public class Shooter : MonoBehaviour
{
    private const int LeftMouse = 0;

    private Gun _gun;

    private void Update()
    {
        if (Input.GetMouseButtonDown(LeftMouse))
            _gun.Shoot();
    }

    public void SetGun(Gun gun)
    {
        _gun = gun;
    }
}
