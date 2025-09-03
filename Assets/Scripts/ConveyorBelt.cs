using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    public float speed = 5f;  // Speed of conveyor belt
    public Vector3 direction = Vector3.forward; // Conveyor movement direction

    private void OnCollisionStay(Collision collision)
    {
        Rigidbody rb = collision.rigidbody;
        if (rb != null)
        {
            // Apply force instead of modifying velocity directly
            rb.AddForce(direction.normalized * speed, ForceMode.Acceleration);
        }
    }
}
