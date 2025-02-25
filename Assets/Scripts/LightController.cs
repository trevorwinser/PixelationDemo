using UnityEngine;

public class LightController : MonoBehaviour
{
    public float rotationSpeed = 360f; // Degrees per second

    void Update()
    {
        // Rotate continuously around the Y-axis
        // transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
