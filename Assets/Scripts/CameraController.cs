using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float rotationSpeed = 60f; // Degrees per second

    void Update()
    {
        // Rotate continuously around the Y-axis
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
