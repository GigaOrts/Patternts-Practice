using UnityEngine;

public class Seller : MonoBehaviour
{
    private Shop _shop;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Player _) == false)
            return;

        _shop.Show();
    }

    public void SetShop(Shop shop)
    {
        _shop = shop;
    }
}
