using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderControllerDots : MonoBehaviour
{

    public Material material;
    ///[Range(0.0f, 1.0f)] public float dimness = 0.5f;
    
    //used to stop this shader and start the next one
    public GameObject currentShaderObject;
    public GameObject nextShaderObject;
    public float handOverDelay = 60;

    //target values
    public Color firstTargetColor1 = Color.yellow;
    public Color secondTargetColor1 = Color.black;

    public Color firstTargetColor2 = Color.yellow;
    public Color secondTargetColor2 = Color.black;
    public float targetSpeed = 3.0f; 

    //durations
    public float colorChangeDuration = 30;

    //refernce values
    float startSpeed;
    public float speed2Multiply = 1.5f; //how much the second set of dots have their speed multiplied by
    Color startColor1;
    Color startColor2;

    //ngl idk what this is for
    private float time = 0.0f;

    public void Start()
    {
        //set initial values
        float startSpeed1 = material.GetFloat("_Speed1");
        float startSpeed2 = material.GetFloat("_Speed2");
        Color startColorInner = material.GetColor("_Color1");
        Color startColorOuter = material.GetColor("_Color2");


        StartCoroutine(ChangeColorOverTime1(firstTargetColor1, colorChangeDuration));
        StartCoroutine(ChangeColorOverTime2(firstTargetColor2, colorChangeDuration));

        StartCoroutine(ChangeSpeedToTarget(targetSpeed));



        StartCoroutine(ShaderHandover());
    }

    void Update()
    {
        
        material.SetFloat("_Time", time);
    }

    IEnumerator ChangeColorOverTime1(Color targetColor, float duration)
    {
        ///Color startColor = material.GetColor("_Color");
        float startTime = Time.time;

        while (Time.time - startTime < duration)
        {
            float t = (Time.time - startTime) / duration;
            Color lerpedColor = Color.Lerp(firstTargetColor1, targetColor, t);
            material.SetColor("_Color1", lerpedColor);
            yield return null;
        }

        material.SetColor("_Color1", targetColor);

        // Start this coroutine again with different values after finishing this one
        StartCoroutine(ChangeColorOverTime1(secondTargetColor1, colorChangeDuration));

    }

    IEnumerator ChangeColorOverTime2(Color targetColor, float duration)
    {
        ///Color startColor = material.GetColor("_Color");
        float startTime = Time.time;

        while (Time.time - startTime < duration)
        {
            float t = (Time.time - startTime) / duration;
            Color lerpedColor = Color.Lerp(firstTargetColor2, targetColor, t);
            material.SetColor("_Color2", lerpedColor);
            yield return null;
        }

        material.SetColor("_Color2", targetColor);

        // Start this coroutine again with different values after finishing this one
        StartCoroutine(ChangeColorOverTime2(secondTargetColor2, colorChangeDuration));

    }

    IEnumerator ChangeSpeedToTarget(float targetSpeed)
    {
        float currentSpeed = startSpeed;

        while (currentSpeed > targetSpeed)
        {
            // Calculate the percentage of remaining speed to reach the target speed
            float t = (currentSpeed - targetSpeed) / (startSpeed - targetSpeed);


            // Calculate the new speed value with the reduction
            float lerpedSpeed = Mathf.Lerp(startSpeed, targetSpeed, t);


            // Set the shader property
            material.SetFloat("_Speed1", lerpedSpeed);
            material.SetFloat("_Speed2", (lerpedSpeed * speed2Multiply));


            // Reduce current speed for the next iteration
            currentSpeed = lerpedSpeed;

            yield return null;
        }

        // Ensure the final speed is exactly the target speed
        material.SetFloat("_Speed1", targetSpeed);
        material.SetFloat("_Speed2", (targetSpeed * speed2Multiply));

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
        material.SetFloat("_Speed1", startSpeed);
        material.SetFloat("_Speed2", (startSpeed * speed2Multiply));


        // Reset colors to its initial value
        material.SetColor("_Color", startColor1);
        material.SetColor("_Color", startColor2);

        // Turn off the objectToTurnOff
        if (currentShaderObject != null)
        {
            currentShaderObject.SetActive(false);
        }

       


    }

}
