using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineLerp : MonoBehaviour
{

    //MOVEMENT LERP PARAMETERS

    private Vector3 endPosition = new Vector3(0, -8, -1);
    private Vector3 startPosition;
    private float duration = 2f; //time between point A and B
    private float elapsedTime;

    [SerializeField]
    private AnimationCurve curve; //curving the Lerp to make line slow down


    //COLOUR LERP PARAMETERS

    /*private float targetAlpha = 1;
    private float fadeDuration = .2f;
    private float lerpParam;
    private float startAlpha = 0;*/
    private Material material;
    private float alphaDuration = .2f;
    private float alphaElapsedTime;    
    private Color startColor;
    private Color endColor;



    void Start()
    {
        startPosition = transform.position; //it's own position

        material = GetComponent<Renderer>().material;
        startColor = material.color;
        endColor.a = 0f;

    }

    //UPDATE CONTAINS ALL MOVEMENT
    void Update()
    {

        
        if (duration < 2f) //trying to begin alpha lerp from colour to see through at the end of the movements' lerp
        {
            if(duration > 1.8f)
            {                
                LerpAlpha();

            }
        }
        
        elapsedTime += Time.deltaTime;
        float percentageComplete = elapsedTime / duration;

        transform.position = Vector3.Lerp(startPosition, endPosition, curve.Evaluate(percentageComplete));
    }


    /*void LerpAlpha()
    {
        lerpParam += Time.deltaTime;

        // Lerp let's you change slowly the value of the alpha        
        float alpha = Mathf.Lerp(startAlpha, targetAlpha, lerpParam / fadeDuration);
        SetMaterialAlpha(alpha);
        if (material.color.a >= 1)
        {
            FadeTo(0);
        }
    }

    // Function to start the fade with the specific alpha with the desired duration
    public void FadeTo(float alpha, float alphaDuration = .2f)
    {
        startAlpha = material.color.a;
        targetAlpha = alpha;
        fadeDuration = alphaDuration;
        lerpParam = 0;
    }

    // Easily change the material alpha with a specific function
    private void SetMaterialAlpha(float alpha)
    {
        Color color = material.color;
        color.a = alpha;
        material.color = color;
    }*/



    private void LerpAlpha()
    {
        alphaElapsedTime += Time.deltaTime;
        float amountComplete = alphaElapsedTime / alphaDuration;

        Color.Lerp(startColor, endColor, amountComplete);       
    }

}
