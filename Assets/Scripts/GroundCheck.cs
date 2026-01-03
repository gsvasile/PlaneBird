using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Ground"))
        {
            return;
        }

        other.transform.position += Vector3.right * 32;
    }
}
