
public class TripleshotGun : Gun
{
    public TripleshotGun() : base(GunConfig.TripleshotGunAmmoPerShot)
    {
    }

    protected override void SpawnBullets()
    {
        for (int i = 0; i < AmmoPerShot; i++)
        {
            base.SpawnBullets();
        }
    }
}
