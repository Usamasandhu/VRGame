using UnityEngine;

public class SimpleRotator : MonoBehaviour
{
    public Vector3 rotationSpeed;  // Rotation speed in degrees per second

    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
