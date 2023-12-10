using UnityEngine;

public class SellerLessonBootstrap : MonoBehaviour
{
    [SerializeField] private Seller _seller;
    [SerializeField] private Player _player;
    [SerializeField] private ShopView _shopView;

    private ShopBehaviuorSwitcher _sellerBehaviorSwitcher;

    private void Awake()
    {
        _sellerBehaviorSwitcher = new ShopBehaviuorSwitcher(_seller, _shopView);
    }

    private void OnEnable()
    {
        _player.ReputationChanged += _sellerBehaviorSwitcher.OnReputationChanged;
    }

    private void OnDisable()
    {
        _player.ReputationChanged -= _sellerBehaviorSwitcher.OnReputationChanged;
    }
}
