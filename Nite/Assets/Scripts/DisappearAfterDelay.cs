using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisappearAfterDelay : MonoBehaviour
{
    public Image targetImage; // Reference to the Image component
    public TextMeshProUGUI targetText; // Reference to the TextMeshProUGUI component
    public float delay = 15f; // Delay in seconds before disappearing

    void Start()
    {
        // Start the coroutine to make objects disappear after delay
        StartCoroutine(DisappearCoroutine());
    }

    private IEnumerator DisappearCoroutine()
    {
        // Wait for the specified delay time
        yield return new WaitForSeconds(delay);

        // Check if the Image component is assigned and active
        if (targetImage != null && targetImage.gameObject.activeSelf)
        {
            // Deactivate or hide the Image component
            targetImage.gameObject.SetActive(false);
        }

        // Check if the TextMeshProUGUI component is assigned and active
        if (targetText != null && targetText.gameObject.activeSelf)
        {
            // Deactivate or hide the TextMeshProUGUI component
            targetText.gameObject.SetActive(false);
        }

        // Optionally, you can destroy the game object instead of deactivating it
        // Destroy(gameObject);
    }
}
