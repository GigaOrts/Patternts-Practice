using UnityEngine;

public class EmptyShop : IShop
{
    public void Show()
    {
        Debug.Log("No items to sell...");
    }
}
