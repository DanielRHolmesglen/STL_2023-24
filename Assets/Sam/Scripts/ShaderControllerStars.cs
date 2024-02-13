using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderControllerStars : MonoBehaviour
{
    public Material material;

    ///Not used currently as this is  the last shader. 
    /* used to stop this shader and start the next one. 
    public GameObject currentShaderObject;
    public GameObject nextShaderObject;
    public float handOverDelay = 60;
    */

    //target values
    public Color firstTargetColor = Color.yellow;
    public Color secondTargetColor = Color.black;
    public float targetSpeed = 3.0f;

    //durations
    public float colorChangeDuration = 30f;
    ///public float firstColorDuration = 30;
    ///public float secondColorDuration = 30;


    //reference values
    float startSpeed;
    float currentSpeed;
    Color startColor;


    private float time = 0.0f;


    public void Start()
    {
        //setting reference valyes
        float startSpeed = material.GetFloat("_DisplacementSpeed");
        Color startColor = material.GetColor("_Color");


        StartCoroutine(ChangeColorOverTime(firstTargetColor, colorChangeDuration));
        StartCoroutine(ChangeSpeedToTarget(targetSpeed));

    }

    void Update()
    {

        material.SetFloat("_Time", time);
    }

    IEnumerator ChangeColorOverTime(Color targetColor, float duration)
    {
        float startTime = Time.time;
        Color startColor = material.GetColor("_Color");

        while (Time.time - startTime < duration)
        {
            float t = (Time.time - startTime) / duration;
            Color lerpedColor = Color.Lerp(startColor, targetColor, t);
            material.SetColor("_Color", lerpedColor);
            yield return null;
        }

        material.SetColor("_Color", targetColor);

        //start this coroutine again one after finishing this coroutine, with different values. It will keep looping though currently.
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
            material.SetFloat("_DisplacementSpeed", lerpedSpeed);

            // Reduce current speed for the next iteration
            currentSpeed = lerpedSpeed;

            yield return null;
        }

        // Ensure the final speed is exactly the target speed
        material.SetFloat("_DisplacementSpeed", targetSpeed);
    }


    /*
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
    */
}
