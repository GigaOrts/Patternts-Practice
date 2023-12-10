using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ShopView : MonoBehaviour
{
    [SerializeField] Sprite[] _sprites;

    private SpriteRenderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _renderer.sprite = _sprites[PlayerConfig.LowReputation];
    }

    public void Render(int reputation)
    {
        _renderer.sprite = _sprites[reputation];
    }
}
