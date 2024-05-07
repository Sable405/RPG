using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public float smoothSpeed = 0.125f; // Speed at which the camera follows the player
    public Vector3 offset; // Offset of the camera from the player

  

    void FixedUpdate()
    {
        if (player != null)
        {
            // Calculate the desired position of the camera
            Vector3 desiredPosition = player.position + offset;

            // Smoothly move the camera towards the desired position
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

            // Update the position of the camera
            transform.position = smoothedPosition;

            // Make sure the camera's rotation remains fixed
            transform.rotation = Quaternion.Euler(47.997f, transform.rotation.eulerAngles.y, 0f);
        }
    }
}
// needs a variable for the camera rotation