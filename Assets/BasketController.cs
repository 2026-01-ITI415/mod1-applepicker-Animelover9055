using UnityEngine;

public class BasketController : MonoBehaviour
{
    public float leftEdge = -20f;
    public float rightEdge = 20f;

    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = -Camera.main.transform.position.z;

        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(worldPos.x, leftEdge, rightEdge);
        transform.position = pos;
    }
}