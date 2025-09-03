using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float bounceForce = 10f; // Adjust this value

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.collider.GetComponent<Rigidbody>();
        if (rb != null)
        {
            // Reset velocity and apply an upward force
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, 0, rb.linearVelocity.z); 
            rb.AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
        }
    }
}
