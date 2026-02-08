using UnityEngine;

public class BasketCatcher : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Apple"))
        {
            Destroy(other.gameObject);
            // (optional) add score here later
        }
    }
}