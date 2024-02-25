using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderController : MonoBehaviour
{
    public Material material;

    public Color[] targetColors; // Array of target colors
    private int currentIndex = 0; // Index of the current target color
    ///public float changeInterval = 5.0f; // Time interval between color changes
    public float colorChangeDuration = 60.0f; // Duration of each color change

    public float targetSpeed = 5.0f;
    public float speedChangeDuration = 180f;


    /*
    //used to inactivate this shader and start the next one
    public GameObject currentShaderObject;
    public GameObject nextShaderObject;
    public float handOverDelay = 90;

    //target values
    public Color firstTargetColor = Color.yellow; 
    public Color secondTargetColor = Color.black;

    //durations
    public float colorChangeDuration = 30;
    ///public float firstColorDuration = 30; 
    ///public float secondColorDuration = 30; 


    //shader speeds
    public float targetSpeed = 2.0f;
    ///public float speedReduction = 0.70f;
    ///public float speedReductionDuration = 3.0f;
    

    private float startSpeed;
    private float currentSpeed;
    private Color startColor;

    private float time = 0.0f;

    
    public void Awake()
    {
        //get initial values
        float startSpeed = material.GetFloat("_Speed");
        Color startColor = firstTargetColor;
    }

    public void Start()
    {
        
        StartCoroutine(ChangeColorOverTime(firstTargetColor, colorChangeDuration));

        StartCoroutine(ChangeSpeedToTarget(targetSpeed));

        StartCoroutine(ShaderHandover());

    }

    void Update()
    {
        
        material.SetFloat("_Time", time);
    }
    */

    void Start()
    {
        // Start the ColorChangeManager coroutine
        StartCoroutine(ColorChangeManager());

        StartCoroutine(ChangeSpeedToTarget(targetSpeed, speedChangeDuration));

    }


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


    /*
    
    IEnumerator ChangeColorOverTime(Color targetColor, float duration)
    {
        float startTime = Time.time;

        while (Time.time - startTime < duration)
        {
            float t = (Time.time - startTime) / duration;
            Color lerpedColor = Color.Lerp(startColor, targetColor, t);
            material.SetColor("_Color", lerpedColor);
            yield return null;
        }

        material.SetColor("_Color", targetColor);


    }
    */

    IEnumerator ChangeSpeedToTarget(float targetSpeed, float duration)
    {
        float startSpeed = GetComponent<Renderer>().material.GetFloat("_Speed"); //shaders speed value
        float startTime = Time.time;

        Debug.Log("Starting speed: " + startSpeed);
        Debug.Log("Target speed: " + targetSpeed);

        while (Time.time - startTime < duration)
        {
            float t = (Time.time - startTime) / duration; // Calculate the percentage of time elapsed

            float lerpedSpeed = Mathf.Lerp(startSpeed, targetSpeed, t); // Calculate the new speed value with the lerp

            GetComponent<Renderer>().material.SetFloat("_Speed", lerpedSpeed);    // Set new shader speed value
            Debug.Log("Calculated Lerp speed: " + lerpedSpeed);
            Debug.Log("Current shader speed: " + material.GetFloat("_Speed"));


            yield return null;
        }

        GetComponent<Renderer>().material.SetFloat("_Speed", targetSpeed); // Making sure final speed matches the target

        Debug.Log("Final speed: " + targetSpeed);

    }

    /*
    IEnumerator ShaderHandover()
    {
        // Wait for the specified delay time
        yield return new WaitForSeconds(handOverDelay);

        // Turn on the objectToTurnOn
        if (nextShaderObject != null)
        {
            nextShaderObject.SetActive(true);
        }

        // Ensure the final speed is exactly the target speed
        material.SetFloat("_Speed", startSpeed);

        // Reset color to its initial value
        material.SetColor("_Color", startColor);

        // Turn off the objectToTurnOff
        if (currentShaderObject != null)
        {
            currentShaderObject.SetActive(false);
        }
    }
    */

    /*
    IEnumerator ChangeSpeedOverTime(float targetSpeed, float duration)
    {
        float startTime = Time.time;
        float startSpeed = material.GetFloat("_Speed");
        float endTime = startTime + speedReductionDuration;


        while (Time.time < endTime)
        {
            // Calculate the percentage of time elapsed
            float t = (Time.time - startTime) / speedReductionDuration;

            // Calculate the new speed value with the reduction
            float lerpedSpeed = Mathf.Lerp(startSpeed, startSpeed * (1.0f - speedReduction), t);

            // Set the shader property
            material.SetFloat("_Speed", lerpedSpeed);

            yield return null;
        }

        // Ensure the final speed is exactly the reduced speed
        material.SetFloat("_Speed", startSpeed * (1.0f - speedReduction));
    }
    */
}
