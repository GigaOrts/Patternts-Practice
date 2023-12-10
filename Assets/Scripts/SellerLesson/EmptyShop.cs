using UnityEngine;

public class EmptyShop : Shop
{
    public override void Show()
    {
        Debug.Log("No items to sell...");
    }
}
