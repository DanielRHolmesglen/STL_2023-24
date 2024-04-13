using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderControllerRing : MonoBehaviour
{

    public Material material;
    ///[Range(0.0f, 1.0f)] public float dimness = 0.5f;
    
    //used to stop this shader and start the next one
    public GameObject currentShaderObject;
    public GameObject nextShaderObject;
    public float handOverDelay = 60;

    //target values
    public Color firstTargetColorInner = Color.yellow;
    public Color secondTargetColorInner = Color.black;

    public Color firstTargetColorOuter = Color.yellow;
    public Color secondTargetColorOuter = Color.black;
    public float targetSpeed = 2.0f;

    //durations
    public float colorChangeDuration = 30;
    ///public float firstColorDuration = 30;
    ///public float secondColorDuration = 30;

    //refernce values
    float startSpeed;
    Color startColorInner;
    Color startColorOuter;

    //ngl idk what this is for
    private float time = 0.0f;


    public void Start()
    {
        //set initial values
        float startSpeed = material.GetFloat("_MovementSpeed");
        Color startColorInner = material.GetColor("_ColorInner");
        Color startColorOuter = material.GetColor("_ColorOuter");


        StartCoroutine(ChangeColorOverTimeInner(firstTargetColorInner, colorChangeDuration));
        StartCoroutine(ChangeColorOverTimeOuter(firstTargetColorOuter, colorChangeDuration));

        StartCoroutine(ChangeSpeedToTarget(targetSpeed));


        StartCoroutine(ShaderHandover());


    }

    void Update()
    {
        
        material.SetFloat("_Time", time);
    }

    IEnumerator ChangeColorOverTimeInner(Color targetColor, float duration)
    {
        ///Color startColor = material.GetColor("_Color");
        float startTime = Time.time;

        while (Time.time - startTime < duration)
        {
            float t = (Time.time - startTime) / duration;
            Color lerpedColor = Color.Lerp(firstTargetColorInner, targetColor, t);
            material.SetColor("_ColorInner", lerpedColor);
            yield return null;
        }

        material.SetColor("_ColorInner", targetColor);

        // Start this coroutine again with different values after finishing this one
        StartCoroutine(ChangeColorOverTimeInner(secondTargetColorInner, colorChangeDuration));

    }

    IEnumerator ChangeColorOverTimeOuter(Color targetColor, float duration)
    {
        ///Color startColor = material.GetColor("_Color");
        float startTime = Time.time;

        while (Time.time - startTime < duration)
        {
            float t = (Time.time - startTime) / duration;
            Color lerpedColor = Color.Lerp(firstTargetColorInner, targetColor, t);
            material.SetColor("_ColorOuter", lerpedColor);
            yield return null;
        }

        material.SetColor("_ColorOuter", targetColor);

        // Start this coroutine again with different values after finishing this one
        StartCoroutine(ChangeColorOverTimeInner(secondTargetColorOuter, colorChangeDuration));

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
            material.SetFloat("_MovementSpeed", lerpedSpeed);

            // Reduce current speed for the next iteration
            currentSpeed = lerpedSpeed;

            yield return null;
        }

        // Ensure the final speed is exactly the target speed
        material.SetFloat("_MovementSpeed", targetSpeed);
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
        material.SetColor("_Color", startColorInner);

        material.SetColor("_Color", startColorOuter);

        // Turn off the objectToTurnOff
        if (currentShaderObject != null)
        {
            currentShaderObject.SetActive(false);
        }

       


    }

}
