using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderController : MonoBehaviour
{

    public Material materialToControl;
    ///[Range(0.0f, 1.0f)] public float dimness = 0.5f;

    public Color targetColor = Color.yellow; // Specify the target color in the Inspector
    public float colorChangeDuration = 10.0f; // Set the duration in the Inspector
    public Color dimColor = Color.black;
    public float dimColorDuration = 10.0f; // Set the duration in the Inspector

    public float speed = 1.0f;
    public float targetSpeed = 2.0f;
    public float speedChangeDuration = 3.0f;

    ///public float targetDimness = 0.3f;
    ///public float dimnessChangeDuration = 2.0f;

    private float time = 0.0f;


    public void Start()
    {
        StartCoroutine(ChangeColorOverTime(targetColor, colorChangeDuration));

        StartCoroutine(ChangeSpeedOverTime(targetSpeed, speedChangeDuration));

        ///StartCoroutine(ChangeDimnessOverTime(targetDimness, dimnessChangeDuration));


    }

    void Update()
    {
        // Update the time based on speed
        ///time += Time.deltaTime * timeSpeed;  
        ///WE COULD USE THIS FOR A "how long do u want experience" option?

        // Set shader properties
        ///materialToControl.SetFloat("_Dimness", dimness);
        materialToControl.SetFloat("_Time", time);
    }

    IEnumerator ChangeColorOverTime(Color targetColor, float duration)
    {
        float startTime = Time.time;
        Color startColor = materialToControl.GetColor("_Color");

        while (Time.time - startTime < duration)
        {
            float t = (Time.time - startTime) / duration;
            Color lerpedColor = Color.Lerp(startColor, targetColor, t);
            materialToControl.SetColor("_Color", lerpedColor);
            yield return null;
        }

        materialToControl.SetColor("_Color", targetColor);

        //start this coroutine again one after finishing this coroutine, with different values. It will keep looping though currently.
        StartCoroutine(ChangeColorOverTime(dimColor, dimColorDuration));
        
    }

    IEnumerator ChangeSpeedOverTime(float targetSpeed, float duration)
    {
        float startTime = Time.time;
        float startSpeed = materialToControl.GetFloat("_Speed");

        while (Time.time - startTime < duration)
        {
            float t = (Time.time - startTime) / duration;
            float lerpedSpeed = Mathf.Lerp(startSpeed, targetSpeed, t);
            materialToControl.SetFloat("_speed", lerpedSpeed);
            yield return null;
        }

        materialToControl.SetFloat("_speed", targetSpeed);
    }

    /*
    IEnumerator ChangeDimnessOverTime(float targetDimness, float duration)
    {
        float startTime = Time.time;
        float startDimness = dimness;

        while (Time.time - startTime < duration)
        {
            float t = (Time.time - startTime) / duration;
            dimness = Mathf.Lerp(startDimness, targetDimness, t);
            yield return null;
        }

        dimness = targetDimness;
    }
    */
}
