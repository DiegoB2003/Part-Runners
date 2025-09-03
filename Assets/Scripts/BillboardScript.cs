using UnityEngine;

public class BillboardScript : MonoBehaviour
{
    private Camera playerCamera;

    private void Update()
    {
        // If we don't have a valid camera, find an active one
        if (playerCamera == null || !playerCamera.isActiveAndEnabled)
        {
            playerCamera = GetActivePlayerCamera();
            if (playerCamera == null) return; // No valid camera found
        }

        // Make the object face the camera
        transform.rotation = Quaternion.Euler(0f, playerCamera.transform.rotation.eulerAngles.y, 0f);
    }

    private Camera GetActivePlayerCamera()
    {
        Camera[] cameras = Camera.allCameras;
        foreach (Camera cam in cameras)
        {
            if (cam.CompareTag("PlayerCamera")) // Ensure player cameras are tagged correctly
                return cam;
        }
        return null; // No player camera found
    }
}
