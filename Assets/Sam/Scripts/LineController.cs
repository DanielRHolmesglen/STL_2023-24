using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour
{
    public Material material;

    public Color[] targetColors; // Array of target colors
    private int currentIndex = 0; // Index of the current target color
    ///public float changeInterval = 5.0f; // Time interval between color changes
    public float colorChangeDuration = 60.0f; // Duration of each color change


    public float durationIncrement = 0.005f; // Amount to increment the duration each time
    public LineLerp lineScript;
    public float desiredDuration = 2f;

    

    void Start()
    {
        // Start the ColorChangeManager coroutine
        ///StartCoroutine(ColorChangeManager());


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

    ///
    /*
    IEnumerator ColorChangeManager()
    {
        while (true)
        {
            // Get the current target color from the array
            Color currentTargetColor = targetColors[currentIndex];

            // Start the ChangeColorOverTime coroutine with the current target color
            StartCoroutine(ChangeColorOverTime(currentTargetColor, colorChangeDuration));

            // Increment the current index, wrapping around to the start if needed
            currentIndex = (currentIndex + 1) % targetColors.Length;

            // Wait for the specified change interval before starting the next color change
            yield return new WaitForSeconds(colorChangeDuration);
        }
    }

    IEnumerator ChangeColorOverTime(Color targetColor, float duration)
    {
        float startTime = Time.time;
        Color startColor = GetComponent<Renderer>().material.GetColor("_Color");

        while (Time.time - startTime < duration)
        {
            float t = (Time.time - startTime) / duration;
            Color lerpedColor = Color.Lerp(startColor, targetColor, t);
            GetComponent<Renderer>().material.SetColor("_Color", lerpedColor);
            yield return null;
        }

        // Ensure the final color is set correctly
        GetComponent<Renderer>().material.SetColor("_Color", targetColor);
    }
    */
  
}
