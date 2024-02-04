using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderController4 : MonoBehaviour
{
    public Material material;

    ///Not used currently as this is  the last shader. 
    /* used to stop this shader and start the next one. 
    public GameObject currentShaderObject;
    public GameObject nextShaderObject;
    public float handOverDelay = 60;
    */
    
    public Color firstTargetColor = Color.yellow;
    public float firstColorDuration = 30;
    public Color secondTargetColor = Color.black;
    public float secondColorDuration = 30;
    

    private float time = 0.0f;


    public void Start()
    {
        StartCoroutine(ChangeColorOverTime(firstTargetColor, firstColorDuration));



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
