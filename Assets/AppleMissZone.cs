using UnityEngine;

public class AppleMissZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Apple"))
        {
            ApplePicker picker = FindObjectOfType<ApplePicker>();

            if (picker != null)
            {
                picker.AppleMissed();
            }
            else
            {
                Debug.LogWarning("No ApplePicker script found in scene.");
            }

            Destroy(other.gameObject);
        }
    }
}