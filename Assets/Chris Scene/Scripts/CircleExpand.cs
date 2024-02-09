using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleExpand : MonoBehaviour
{

    public GameObject plane;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*void mainImage(out vec4 color, in vec2 pixCoords)
    {
        float frequence = 2.0;
        float pulse = sin(iTime * 1.0 * 3.14 * 2.0 * frequence);


        float centerX = iResolution.x / 2.0;
        float centerY = iResolution.y / 2.0;
        float rayon = 100.0;
        rayon = rayon + rayon * 0.2 * pulse;
        float distance = sqrt(pow(centerX - pixCoords.x, 2.0) + pow(centerY - pixCoords.y, 2.0));
        if (distance < rayon)
        {
            color = vec4(1.0, 0.0, 0.0, 1.0);
        }
        else
        {
            color = vec4(1.0, 1.0, 1.0, 1.0);

        }
        //rayon = rayon + rayon*0.5*pulse;
    }*/
}
