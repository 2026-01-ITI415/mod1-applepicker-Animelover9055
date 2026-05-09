using UnityEngine;

public class BasketCatcher : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Apple"))
        {
            Destroy(other.gameObject);

            ScoreCounter.score += 100;
        }
    }
}