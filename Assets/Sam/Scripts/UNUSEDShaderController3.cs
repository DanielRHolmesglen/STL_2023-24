using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UNUSEDShaderConrtoller3 : MonoBehaviour
{

    public Material material;

    // used to stop this shader and start the next one. 
    public GameObject currentShaderObject;
    public GameObject nextShaderObject;
    public float handOverDelay = 60;
   

    //target values
    public float targetSpeed = 0.5f;
    public float targetIntensity = 0.5f; //shader intensity (aka how much colour)

    //durations
    public float speedReductionDuration = 60.0f;
    public float intensityReductionDuration = 60.0f;



    //reference values
    public Color startColor;
    public float startSpeed;

    private float time = 0.0f;


    public void Start()
    {
        Color startColor = material.GetColor("_Color");
        float startSpeed = material.GetFloat("_D1I");


        ///StartCoroutine(ChangeColorOverTime(firstTargetColor, firstColorDuration));

        StartCoroutine(ChangeSpeedToTarget(targetSpeed));

        StartCoroutine(ChangeIntensityOverTime(targetSpeed, speedReductionDuration));


        ///StartCoroutine(ShaderHandover());

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

        //start this coroutine again one after finishing this coroutine, with different values. It will keep looping though currently.
        ///StartCoroutine(ChangeColorOverTime(secondTargetColor, secondColorDuration));

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
            material.SetFloat("_D1Speed", lerpedSpeed);

            // Reduce current speed for the next iteration
            currentSpeed = lerpedSpeed;

            yield return null;
        }

        // Ensure the final speed is exactly the target speed
        material.SetFloat("_D1Speed", targetSpeed);
    }

    IEnumerator ChangeIntensityOverTime(float targetIntensity, float duration)
    {
        float startTime = Time.time;
        float endTime = startTime + speedReductionDuration;


        while (Time.time < endTime)
        {
            // Calculate the percentage of time elapsed
            float t = (Time.time - startTime) / speedReductionDuration;

            // Calculate the new speed value with the reduction
            float lerpedIntensity = Mathf.Lerp(startSpeed, targetIntensity, t);

            // Set the shader property
            material.SetFloat("_D1I", lerpedIntensity);

            yield return null;
        }

        // Ensure the final speed is exactly the reduced speed
        material.SetFloat("_D1Speed", targetIntensity);
    }

    
    IEnumerator ShaderHandover()
    {
        // Wait for the specified delay time
        yield return new WaitForSeconds(handOverDelay);

        // Turn off the objectToTurnOff
        if (currentShaderObject != null)
        {
            currentShaderObject.SetActive(false);
        }

        // Turn on the objectToTurnOn
        if (nextShaderObject != null)
        {
            nextShaderObject.SetActive(true);
        }
    }

}


