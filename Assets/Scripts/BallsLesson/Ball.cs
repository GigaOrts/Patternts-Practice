using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private BallColor _color;

    public BallColor Color => _color;

    private void OnMouseDown()
    {
        gameObject.SetActive(false);
    }
}
