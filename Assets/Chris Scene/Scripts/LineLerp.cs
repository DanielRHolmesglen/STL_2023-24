using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class LineLerp : MonoBehaviour
{

    //MOVEMENT LERP PARAMETERS

    public GameObject endPositionEmpty;
    public GameObject startPositionEmpty;
    private Vector3 endPosition;
    private Vector3 startPosition;
    public float duration = 2.000f; //time between point A and B
    private float elapsedTime;
    GameObject lineMat;
    public GameObject centerEye;
    //private Vector3 centreEyePos;

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


    public UnityEvent OnLineReset;



    void Start()
    {        
        lineMat = this.gameObject;

        //material = GetComponent<Renderer>().material;
        //startColor = material.color;
        //endColor.a = 0f;

    }

    //UPDATE CONTAINS ALL MOVEMENT
    void Update()
    {
        startPosition = startPositionEmpty.transform.position; //it's own position (empty game object)
        endPosition = endPositionEmpty.transform.position; //empty game object end pos

        //centerEye.transform.position = centreEyePos; //storing Vector3 for "centerEye"

        /*if (elapsedTime < 2f) //trying to begin alpha lerp from colour to see through at the end of the movements' lerp
        {
            if(elapsedTime > 1.8f)
            {                
                LerpAlpha();

            }
        }*/

        elapsedTime += Time.deltaTime;
        float percentageComplete = elapsedTime / duration;

        transform.position = Vector3.Lerp(startPosition, endPosition, curve.Evaluate(percentageComplete));

        if(transform.position == endPosition)
        {
            Resetting();
        }
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



    /*private void LerpAlpha()
    {
        alphaElapsedTime += Time.deltaTime;
        float amountComplete = alphaElapsedTime / alphaDuration;

        Color.Lerp(startColor, endColor, amountComplete);       
    }*/

    //RESETTING ALL THE PARAMETERS FOR LINE TO START AGAIN
    private void Resetting() 
    {
        lineMat.SetActive(false);
        transform.position = startPosition; 
        elapsedTime = 0;
        lineMat.SetActive(true);

        //invoking event so other scripts can register this
        OnLineReset.Invoke();

    }

}
