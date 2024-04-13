using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using Liminal.SDK.VR;
using Liminal.SDK.VR.Input;



public class GameManager : MonoBehaviour
{

    public GameObject introSequenceUI;
    public Text introText; //refernce to change the text

    public string[] introTexts; // Array of predetermined texts
    private int currentIndex = 0; // Index of the current text being displayed
    public float textDisplayDuration = 7f; // Duration to display each text

    public GameObject[] introImages; //UNUSED 
    //public AudioSource[] introSounds;  UNUSED
    public GameObject audioManagerObject; //reference to turn it on when intro is over
    public GameObject movingLine; //reference to turn it on when intro is over

    private bool introSkipped = false;


    void Start()
    {
        // Start the intro sequence
        StartCoroutine(StartIntroSequence());
        ///StartCoroutine(Images());

        StartCoroutine(DisplayTexts());


    }

    private void Update()
    {

        var input = VRDevice.Device.PrimaryInputDevice; //setting up vr device. IS PRIMARY/RIGHT HAND.

        if (!introSkipped && input.GetButtonDown(VRButton.Primary) || !introSkipped && Input.GetMouseButtonDown(0)) //Checking every frame if button is being pressed
        {
            EndIntroSequence();


        }



    }

    IEnumerator DisplayTexts()
    {
        //let initial text be displayed
        introText.text = introTexts[currentIndex];
        yield return new WaitForSeconds(textDisplayDuration);


        if (currentIndex == introTexts.Length - 1)
        {
            // Call the SkipIntroSequence method
            EndIntroSequence();
            StopCoroutine(DisplayTexts());
        }
        else
        {
            // Move to the next text in the array
            currentIndex = (currentIndex + 1 % introTexts.Length);
            StartCoroutine(DisplayTexts());
        }


    }



    IEnumerator StartIntroSequence()
    {
        // Show intro UI and set initial text
        introSequenceUI.SetActive(true);
        introImages[0].gameObject.SetActive(true);
        ///introText.text = "Welcome. Press A to skip the induction or right trigger to skip a step";

        //waiting for the (I think) total time the intro should take if nothing is skipped.
        yield return new WaitForSeconds(textDisplayDuration * (introTexts.Length));



    }

    void EndIntroSequence()
    {
        StopAllCoroutines(); // Stop the intro sequence coroutine
        introSkipped = true;

        // Turn off intro UI
        introSequenceUI.SetActive(false);
        introImages[0].gameObject.SetActive(false);


        // Start the AudioManager and ShaderController after delays
        audioManagerObject.SetActive(true);
        movingLine.SetActive(true);
    }

    /// UNUSED INTRO SKIP EACH SLIDE 
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


    /*
    if (!introSkipped && input.GetButtonDown(VRButton.Primary) || !introSkipped && Input.GetMouseButtonDown(0)) //Checking every frame if button is being pressed
    {
        introSkipped = true;

        StopCoroutine(DisplayTexts());
        if (currentIndex == introTexts.Length - 1)
        {
            EndIntroSequence();
            StopCoroutine(DisplayTexts());
        }
        else
        {
            currentIndex = (currentIndex + 1) % introTexts.Length;
        }
        StartCoroutine(DisplayTexts());

        introSkipped = false;
    }
    */


    /*
    introImages[1].gameObject.SetActive(true);
    introText.text = "Evening, astronaut. I know your day was draining and that you are preparing to rest. I'm conducting a final checkup to make sure you are comfortable.";
    yield return new WaitForSeconds(7f);

    introText.text = "You may notice various lights and sounds throughout the ship as it continues its operations. These are routine functions of our vessel, ensuring your safety and comfort";
    yield return new WaitForSeconds(7f);

    introText.text = "Should you require any assistance, press home for the menu. Now, please close your eyes for this experience and relax, knowing you are safe. Good night astronaut.";
    yield return new WaitForSeconds(7f);
    introImages[1].gameObject.SetActive(false);
    */
}
