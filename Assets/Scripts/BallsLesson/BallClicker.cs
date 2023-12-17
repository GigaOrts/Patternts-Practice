using UnityEngine;

public class BallClicker : MonoBehaviour
{
    private const int LeftMouseButton = 0;

    private void Update()
    {
        if (Input.GetMouseButtonDown(LeftMouseButton))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D raycastHit2D = Physics2D.Raycast(ray.origin, ray.direction);

            if (raycastHit2D == default)
                return;

            if(raycastHit2D.collider.TryGetComponent(out Ball ball))
            {
                ball.Deactivate();
            }
        }
    }
}
