using System.Collections;
using UnityEngine;

public class NEWLineController : MonoBehaviour
{
    public Color startColor;
    public Color targetColor;
   
    public Color[] colors; // Array of target colors
    private int currentIndex = 0; // Index of the current target color
    public float totalColorChangeDuration = 300f;
    public float colorChangeDuration = 60.0f; // Duration of each color change

    public float durationIncrement = 0.005f; // Amount to increment the duration each time
    public LineLerp lineScript;
    public float desiredDuration = 2f;
    

    private Renderer renderer;

    private void Awake()
    {
        // Get the Renderer component
        renderer = GetComponent<Renderer>();

        //calculating the duration for each color change
        colorChangeDuration = totalColorChangeDuration / (colors.Length);

        //calcualating the incredment to slow line speed per 'tick'
        durationIncrement = (desiredDuration - lineScript.duration) / totalColorChangeDuration;
    }

    private void Start()
    {

        startColor = renderer.material.color;
        targetColor = colors[currentIndex];

        StartCoroutine(LerpColor());

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

    
    private IEnumerator LerpColor()
    {
        while (true)
        {
            Debug.Log("getting start and target color");
            Color startColor = GetComponent<Renderer>().material.color;
            Color targetColor = colors[currentIndex];

            // Initialize lerp timer
            float elapsedTime = 0f;

            // Lerp the color over time
            while (elapsedTime < colorChangeDuration)
            {
                Debug.Log("while looping");

                // Calculate lerp ratio
                float lerp = elapsedTime / colorChangeDuration;

                // Lerp the color
                Color lerpedColor = Color.Lerp(startColor, targetColor, lerp);

                // Set both color and emissive color
                GetComponent<Renderer>().material.SetColor("_BaseColor", lerpedColor);
                GetComponent<Renderer>().material.SetColor("_Color", lerpedColor);
                GetComponent<Renderer>().material.SetColor("_MainColor", lerpedColor);
                GetComponent<Renderer>().material.color = lerpedColor;
                GetComponent<Renderer>().material.SetColor("_EmissionColor", lerpedColor);
                ///renderer.material.color = colors[currentIndex];

                //Reduntant line of code
                // renderer.material.color = Color.Lerp(startColor, targetColor, elapsedTime / colorChangeDuration);

                // Update elapsed time
                elapsedTime += Time.deltaTime;

                // Wait for the end of the frame
                yield return new WaitForEndOfFrame();
            }
            Debug.Log("exiting loop");

            // Ensure the target color is reached
            ///SetMaterialColor(renderer.material, targetColor);
            ///renderer.material.color = colors[currentIndex];
            ///renderer.material.SetColor("_EmissionColor", colors[currentIndex]);
            renderer.material.SetColor("_Color", colors[currentIndex]);
            renderer.material.color = colors[currentIndex];
            renderer.material.SetColor("_EmissionColor", colors[currentIndex]);

            // Move to the next color in the array
            currentIndex = (currentIndex + 1) % colors.Length;
         //   StartCoroutine(LerpColor());
        }
    }
    
    /*
    private IEnumerator LerpColor()
    {
        float elapsedTime = 0f;

        while (elapsedTime < colorChangeDuration)
        {
            renderer.material.color = Color.Lerp(startColor, targetColor, elapsedTime / colorChangeDuration);
            elapsedTime += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

        renderer.material.color = targetColor;

        // Move to the next color in the array
        currentIndex = (currentIndex + 1) % colors.Length;
        startColor = targetColor;
        targetColor = colors[currentIndex];

        StartCoroutine(LerpColor());
    }
    */
}
