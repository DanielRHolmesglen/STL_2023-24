using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderController : MonoBehaviour
{

    public Material material;
    ///[Range(0.0f, 1.0f)] public float dimness = 0.5f;
    
    //used to stop this shader and start the next one
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

        // Update startColor for the next iteration or use case
        startColor = targetColor;

        // Start this coroutine again with different values after finishing this one
        StartCoroutine(ChangeColorOverTime(secondTargetColor, colorChangeDuration));

    }

    IEnumerator ChangeSpeedToTarget(float targetSpeed)
    {
        ///float startSpeed = material.GetFloat("_Speed");
        float currentSpeed = startSpeed;

        while (currentSpeed > targetSpeed)
        {
            // Calculate the percentage of remaining speed to reach the target speed
            float t = (currentSpeed - targetSpeed) / (startSpeed - targetSpeed);

            // Calculate the new speed value with the reduction
            float lerpedSpeed = Mathf.Lerp(startSpeed, targetSpeed, t);

            // Set the shader property
            material.SetFloat("_Speed", lerpedSpeed);

            // Reduce current speed for the next iteration
            currentSpeed = lerpedSpeed;

            yield return null;
        }

        // Ensure the final speed is exactly the target speed
        material.SetFloat("_Speed", targetSpeed);
    }

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
