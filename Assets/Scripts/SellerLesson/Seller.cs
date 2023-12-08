using System.Collections.Generic;
using UnityEngine;

public class Seller : MonoBehaviour
{
    private Dictionary<int, IShop> _shops;

    private void Awake()
    {
        _shops = new()
        {
            {0, new EmptyShop() },
            {1, new ArmorShop() },
            {2, new FoodShop() },
        };
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PlayerBuyer buyer) == false)
            return;

        IShop shop = _shops[buyer.Reputation];
        shop.Show();
    }
}
