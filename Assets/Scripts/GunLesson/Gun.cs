using UnityEngine;

public abstract class Gun : IGun
{
    private readonly int _maxAmmoCount = 100;
    private int AmmoCount;

    protected int AmmoPerShot;

    public Gun(int ammoPerShot)
    {
        AmmoCount = _maxAmmoCount;
        AmmoPerShot = ammoPerShot;
    }

    private bool CanShoot => AmmoCount >= AmmoPerShot;

    public void Shoot()
    {
        if (CanShoot == false)
            return;

        SpawnBullets();
        UpdateAmmo();
    }

    protected virtual void SpawnBullets()
    {
        Debug.Log("Bullet spawned...");
    }

    private void UpdateAmmo()
    {
        AmmoCount -= AmmoPerShot;
        Debug.Log($"Bullets: {AmmoCount} / {_maxAmmoCount} || -{AmmoPerShot}");
    }
}
