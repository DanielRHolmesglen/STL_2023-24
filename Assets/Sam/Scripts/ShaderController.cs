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

    public Color firstTargetColor = Color.yellow; 
    public float firstColorDuration = 30; 
    public Color secondTargetColor = Color.black;
    public float secondColorDuration = 30; 

    //shader speeds
    public float targetSpeed = 2.0f;
    public float speedReduction = 0.70f; 
    public float speedReductionDuration = 3.0f;

    private float time = 0.0f;


    public void Start()
    {
        StartCoroutine(ChangeColorOverTime(firstTargetColor, firstColorDuration));

        StartCoroutine(ChangeSpeedOverTime(targetSpeed, speedReductionDuration));

        StartCoroutine(ShaderHandover());

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
        StartCoroutine(ChangeColorOverTime(secondTargetColor, secondColorDuration));
        
    }

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
