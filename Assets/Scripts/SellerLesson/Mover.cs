using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        transform.Translate(_speed * Time.deltaTime * new Vector2(horizontal, vertical));
    }
}
