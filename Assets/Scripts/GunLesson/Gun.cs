using System;
using UnityEngine;

public abstract class Gun
{
    private readonly int _maxAmmoCount = 100;
    protected readonly int AmmoPerShot;
    
    private int _ammoCount;

    public Gun(int ammoPerShot)
    {
        AmmoPerShot = ammoPerShot;
        _ammoCount = _maxAmmoCount;
    }

    private bool CanShoot => _ammoCount >= AmmoPerShot;

    public void Shoot()
    {
        if (CanShoot == false)
            throw new InvalidOperationException();

        SpawnBullets();
        UpdateAmmo();
    }

    protected virtual void SpawnBullets()
    {
        Debug.Log("Bullet spawned...");
    }

    private void UpdateAmmo()
    {
        _ammoCount -= AmmoPerShot;
        Debug.Log($"Bullets: {_ammoCount} / {_maxAmmoCount} || -{AmmoPerShot}");
    }
}
