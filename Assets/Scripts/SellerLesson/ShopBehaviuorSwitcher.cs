using System.Collections.Generic;

public class ShopBehaviuorSwitcher
{
    private readonly Dictionary<int, Shop> _shops;
    private readonly Seller _seller;
    private readonly ShopView _shopView;

    public ShopBehaviuorSwitcher(Seller seller, ShopView shopView)
    {
        _shops = new()
        {
            {PlayerConfig.LowReputation, new EmptyShop() },
            {PlayerConfig.NormalReputation, new ArmorShop() },
            {PlayerConfig.HighReputation, new FoodShop() },
        };

        _shopView = shopView;
        _seller = seller;

        _seller.SetShop(_shops[PlayerConfig.LowReputation]);
    }

    public void OnReputationChanged(int reputation)
    {
        _seller.SetShop(_shops[reputation]);
        _shopView.Render(reputation);
    }
}