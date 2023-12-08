
public class TripleshotGun : Gun
{
    public TripleshotGun() : base(3)
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
