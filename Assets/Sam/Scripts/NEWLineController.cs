using System.Collections;
using UnityEngine;

public class NEWLineController : MonoBehaviour
{
    public Renderer renderer; 
    public Color[] colors; // Array of target colors
    private int currentIndex = 0; // Index of the current target color
    public float colorChangeDuration = 60.0f; // Duration of each color change

    public float durationIncrement = 0.005f; // Amount to increment the duration each time
    public LineLerp lineScript;
    public float desiredDuration = 2f;

    private void Start()
    {
        StartCoroutine(LerpColors());

        // Subscribe to the OnLineReset event
        lineScript.OnLineReset.AddListener(AdjustDuration);
    }

    void AdjustDuration()
    {
        // Check if the duration has reached the desired value
        if (lineScript.duration >= desiredDuration)
        {
            // Perform any additional actions or stop adjusting the speed
            Debug.Log("Duration reached desired value.");
        }
        else
        {
            // Adjust the duration variable in the target script
            lineScript.duration += durationIncrement;
        }
    }

    private IEnumerator LerpColors()
    {
        while (true)
        {
            Color startColor = renderer.material.color;
            Color targetColor = colors[currentIndex];

            // Initialize lerp timer
            float elapsedTime = 0f;

            // Lerp the color over time
            while (elapsedTime < colorChangeDuration)
            {
                // Calculate lerp ratio
                float lerp = elapsedTime / colorChangeDuration;

                // Lerp the color
                Color lerpedColor = Color.Lerp(startColor, targetColor, lerp);

                // Set both color and emissive color
                renderer.material.SetColor("_Color", lerpedColor);
                renderer.material.color = lerpedColor;
                renderer.material.SetColor("_EmissionColor", lerpedColor);
                ///renderer.material.color = colors[currentIndex];



                // Update elapsed time
                elapsedTime += Time.deltaTime;

                // Wait for the end of the frame
                yield return null;
            }

            // Ensure the target color is reached
            ///SetMaterialColor(renderer.material, targetColor);
            ///renderer.material.color = colors[currentIndex];
            ///renderer.material.SetColor("_EmissionColor", colors[currentIndex]);
            renderer.material.SetColor("_Color", colors[currentIndex]);
            renderer.material.color = colors[currentIndex];
            renderer.material.SetColor("_EmissionColor", colors[currentIndex]);

            // Move to the next color in the array
            currentIndex = (currentIndex + 1) % colors.Length;
        }
    }
}
