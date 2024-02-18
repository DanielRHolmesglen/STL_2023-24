using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class GameManager : MonoBehaviour
{
    public float audioManagerDelay = 1f; 
    public float shaderControllerDelay = 1f; 

    public GameObject introSequenceUI;
    public Text introText;
    public GameObject[] introImages;
    public AudioSource[] introSounds;

    public GameObject audioManagerObject; 
    public GameObject shaderControllerObject;

    private bool introSkipped = false;


    void Start()
    {
        // Start the intro sequence
        StartCoroutine(IntroSequence());
        ///StartCoroutine(Images());

    }

    void Update()
    {
        // Check for skip input 
        if (!introSkipped && OVRInput.GetDown(OVRInput.Button.One)) 
        {
            SkipIntroSequence();
        }
    }


    IEnumerator IntroSequence()
    {
        // Show intro UI and set initial text
        introSequenceUI.SetActive(true);
        introImages[0].gameObject.SetActive(true);
        introText.text = "Initialising... Press the A button to skip the induction";
        yield return new WaitForSeconds(3f);

        introImages[0].gameObject.SetActive(false);
        introImages[1].gameObject.SetActive(true);
        introText.text = "Evening, astronaut. I know your day was draining and that you are preparing to rest. I'm conducting a final checkup to make sure you are comfortable.";
        yield return new WaitForSeconds(7f);

        introText.text = "You may notice various lights and sounds throughout the ship as it continues its operations. These are routine functions of our vessel, ensuring your safety and comfort";
        yield return new WaitForSeconds(7f);

        introImages[1].gameObject.SetActive(false);
        introImages[2].gameObject.SetActive(true);
        introText.text = "Should you require any assistance, press XYZ for the menu. Now, please close your eyes for this experience and relax, knowing you are safe. Good night astronaut.";
        yield return new WaitForSeconds(7f);

        // Turn off intro UI
        introSequenceUI.SetActive(false);

        // Start the AudioManager and ShaderController
        ///yield return new WaitForSeconds(audioManagerDelay);
        audioManagerObject.SetActive(true);
        ///yield return new WaitForSeconds(shaderControllerDelay);
        shaderControllerObject.SetActive(true);
    }

    void SkipIntroSequence()
    {
        StopAllCoroutines(); // Stop the intro sequence coroutine
        introSkipped = true;

        // Turn off intro UI
        introSequenceUI.SetActive(false);

        // Start the AudioManager and ShaderController after delays
        audioManagerObject.SetActive(true);
        shaderControllerObject.SetActive(true);
    }

    /*
    IEnumerator Images()
    {
        
        // Show and hide images with delay
        foreach (var image in introImages)
        {
            image.gameObject.SetActive(true);
            yield return new WaitForSeconds(1f);
            image.gameObject.SetActive(false);
        }

    }
    */
}
