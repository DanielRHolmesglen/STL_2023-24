using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour
{
    public MeshRenderer renderer;
    ///public Material material;
    ///private Material _instancedMat;
    ///private Material[] _mats;


    public Color[] colors; // Array of target colors
    public Color startColor; //debugging
    public Color targetColor; //debugging
    private int currentIndex = 0; // Index of the current target color
    public float colorChangeDuration = 60.0f; // Duration of each color change


    public float durationIncrement = 0.005f; // Amount to increment the duration each time
    public LineLerp lineScript;
    public float desiredDuration = 2f;


    private void Awake()
    {
        // Create a new instance
        ///_instancedMat = Instantiate(material);
        // add the instance to an array of materials 
        ///_mats = new Material[] { _instancedMat };
        // Set the materials of the renderer to this array
        ///renderer.materials = _mats;


    }
    void Start()
    {
        // Start the ColorChangeManager coroutine
        ///StartCoroutine(ColorChangeManager

        StartCoroutine(LerpColors());

        // Subscribe to the OnLineReset event
        lineScript.OnLineReset.AddListener(AdjustDuration);

        ///_instancedMat.color = colors[1];
        
        /* THESE WORK
        renderer.material.GetColor("_Color");
        renderer.material.SetColor("_Color", colors[1]);
        */

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

    IEnumerator LerpColors()
    {
        while (true)
        {
            // Calculate the starting and target colors
            ///Color startColor = _instancedMat.color;

            Color startColor = renderer.material.GetColor("_Color");
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

                // Apply the lerped color to the material
                ///_instancedMat.color = lerpedColor;
                
                ///renderer.material.GetColor("_Color");
                renderer.material.SetColor("_Color", lerpedColor);
                ///renderer.material.color = Color.Lerp(startColor, targetColor, lerp);


                // Update elapsed time
                elapsedTime += Time.deltaTime;

                // Wait for the end of the frame
                yield return null;
            }

            // Ensure the target color is reached
            ///_instancedMat.color = targetColor;
            renderer.material.SetColor("_Color", colors[currentIndex]);

            // Move to the next color in the array
            currentIndex = (currentIndex + 1) % colors.Length;
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
