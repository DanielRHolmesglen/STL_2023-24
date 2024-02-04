using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondShaderController : MonoBehaviour
{

    public Material material;
    ///[Range(0.0f, 1.0f)] public float dimness = 0.5f;
    
    //used to stop this shader and start the next one
    public GameObject currentShaderObject;
    public GameObject nextShaderObject;
    public float handOverDelay = 60;

    public Color firstTargetColor1 = Color.yellow;
    public Color firstTargetColor2 = Color.yellow;
    public float firstColorDuration = 30; 
    public Color secondTargetColor1 = Color.black;
    public Color secondTargetColor2 = Color.black;
    public float secondColorDuration = 30;

    //shader speeds
    public float targetSpeed1 = 2.0f;
    public float speedReduction1 = 0.70f; 
    public float targetSpeed2 = 2.0f;
    public float speedReduction2 = 0.70f; 
    public float speedReductionDuration = 60.0f;

    private float time = 0.0f;


    public void Start()
    {
        StartCoroutine(ChangeColorOverTime1(firstTargetColor1, firstColorDuration));
        StartCoroutine(ChangeColorOverTime2(firstTargetColor2, firstColorDuration));

        StartCoroutine(ChangeSpeedOverTime1(targetSpeed1, speedReductionDuration));
        StartCoroutine(ChangeSpeedOverTime2(targetSpeed2, speedReductionDuration));


        StartCoroutine(ShaderHandover());

    }

    void Update()
    {
        
        material.SetFloat("_Time", time);
    }

    IEnumerator ChangeColorOverTime1(Color targetColor, float duration)
    {
        float startTime = Time.time;
        Color startColor = material.GetColor("_Color1");


        while (Time.time - startTime < duration)
        {
            float t = (Time.time - startTime) / duration;
            Color lerpedColor = Color.Lerp(startColor, targetColor, t);
            material.SetColor("_Color1", lerpedColor);

            yield return null;
        }

        material.SetColor("_Color1", targetColor);


        //start this coroutine again one after finishing this coroutine, with different values. It will keep looping though currently.
        StartCoroutine(ChangeColorOverTime1(secondTargetColor1, secondColorDuration));
        
    }

    IEnumerator ChangeColorOverTime2(Color targetColor, float duration)
    {
        float startTime = Time.time;
        Color startColor = material.GetColor("_Color2");


        while (Time.time - startTime < duration)
        {
            float t = (Time.time - startTime) / duration;
            Color lerpedColor = Color.Lerp(startColor, targetColor, t);
            material.SetColor("_Color2", lerpedColor);

            yield return null;
        }

        material.SetColor("_Color2", targetColor);


        //start this coroutine again one after finishing this coroutine, with different values. It will keep looping though currently.
        StartCoroutine(ChangeColorOverTime2(secondTargetColor2, secondColorDuration));

    }

    IEnumerator ChangeSpeedOverTime1(float targetSpeed, float duration)
    {
        float startTime = Time.time;
        float startSpeed = material.GetFloat("_Speed1");
        float endTime = startTime + speedReductionDuration;


        while (Time.time < endTime)
        {
            // Calculate the percentage of time elapsed
            float t = (Time.time - startTime) / speedReductionDuration;

            // Calculate the new speed value with the reduction
            float lerpedSpeed = Mathf.Lerp(startSpeed, startSpeed * (1.0f - speedReduction1), t);

            // Set the shader property
            material.SetFloat("_Speed1", lerpedSpeed);

            yield return null;
        }

        // Ensure the final speed is exactly the reduced speed
        material.SetFloat("_Speed1", startSpeed * (1.0f - speedReduction1));
    }

    IEnumerator ChangeSpeedOverTime2(float targetSpeed, float duration)
    {
        float startTime = Time.time;
        float startSpeed = material.GetFloat("_Speed2");
        float endTime = startTime + speedReductionDuration;


        while (Time.time < endTime)
        {
            // Calculate the percentage of time elapsed
            float t = (Time.time - startTime) / speedReductionDuration;

            // Calculate the new speed value with the reduction
            float lerpedSpeed = Mathf.Lerp(startSpeed, startSpeed * (1.0f - speedReduction2), t);

            // Set the shader property
            material.SetFloat("_Speed2", lerpedSpeed);

            yield return null;
        }

        // Ensure the final speed is exactly the reduced speed
        material.SetFloat("_Speed2", startSpeed * (1.0f - speedReduction2));
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
