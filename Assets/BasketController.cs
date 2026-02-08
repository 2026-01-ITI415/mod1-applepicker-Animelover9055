using UnityEngine;

public class BasketController : MonoBehaviour
{
    public float speed = 10f;
    public float leftEdge = -20f;
    public float rightEdge = 20f;

    void Update()
    {
        float move = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.position += new Vector3(move, 0f, 0f);

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, leftEdge, rightEdge);
        transform.position = pos;
    }
}