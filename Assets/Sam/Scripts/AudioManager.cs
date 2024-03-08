using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    
    public AudioSource backgroundAmbience;    
    public AudioSource bgMusic;
    ///public AudioSource shipPulse;
    public AudioSource shipHum;
    public AudioClip[] shipHums;
    public AudioSource fan;
    public AudioSource hydraulics;

    public float minHydraulicsInterval = 20f;
    public float maxHydraulicsInterval = 20f;


    public float linePitchIncrement = 0.005f; //reduces pitch by this amount each time line is reset
    public float linePitchReduction = 0.5f; //how much to overall reduce pitch


    public LineLerp lineScript;
    public LineController lineController;


    //Lowering overall volume
    public float decreaseDuration = 300f;  // The duration over which to decrease overall volume and pitch

    ///public float noiseReductionDelay = 30f; //how long before it starts to reduce sound
    public float noiseDecreasePercentage = 0.50f; // The total percentage by which to decrease the volume

    //slowly decreasing speed/pitch
    ///public float pitchReductionDelay = 30f; //how long before it starts to reduce sound
    public float pitchDecreasePercentage = 0.50f; // The total percentage by which to decrease the volume
    ///public float speedDecreaseDuration = 300f;  // The duration over which to decrease the volume



    /*
    public AudioSource doorOpen;    
    public AudioSource footsteps;    
    public AudioSource chatter;        
    public AudioSource lifeSupport;
    public AudioSource radar;
    public AudioSource music;
    public AudioSource shower;


    
    //arrays of audio clips if a source can have more than 1 sound
    public AudioClip[] doorOpenSounds;
    public AudioClip[] footstepsSounds;
    public AudioClip[] chatterSounds;
    public AudioClip[] lifeSupportSounds;
    public AudioClip[] musicSounds;



    //randomly played sounds (every bewteen X and Y seconds)
    public float footstepsMinInterval = 15f;
    public float footstepsMaxInterval = 25f;
    public float doorOpenMinInterval = 20f;
    public float doorOpenMaxInterval = 30f;
    public float chatterMinInterval = 30f;
    public float chatterMaxInterval = 40f;
    public float musicMinInterval = 30f;
    public float musicMaxInterval = 45f;
    public float showerMinInterval = 40f;
    public float showerMaxInterval = 60f;


    //Periodically played sounds (every X seconds)
    ///public float lifeSupportInterval = 20f;
    public float radarInterval = 35f;
    ///public float shipPulseInterval = 40f;
    

    //some specific volume adjustments
    public float shipPulseVolumePercentage = 0.5f; // Target volume percentage (0 to 1)
    public float shipPulseChangeSpeed = 0.5f; // Volume change speed per second



    */




    ///public float volumeAdjustmentInterval;
    ///public float shipPulseVolumeChangePercentage;
    ///public float shipPulseVolumeChangeInterval;


    void Start()
    {
        //start playing background looping sounds 
        backgroundAmbience.loop = true;
        backgroundAmbience.Play();

        bgMusic.loop = true;
        bgMusic.Play();

        fan.loop = true;
        fan.Play();

        //start gradually decreasing volumes and slow things down
        StartCoroutine(ManageAudioVolumes());
        StartCoroutine(ManageAudioPitches());


        //adding listeners for hum to match with line
        lineScript.OnLineReset.AddListener(AdjustHumPitch);
        lineScript.OnLineReset.AddListener(PlayHum);

        //begin random sounds 
        StartCoroutine(PlayHydraulics());



        ///shipHum.loop = true;
        ///shipHum.Play();

        /*
        //start playing periodical/random sounds
        StartCoroutine(PlayDoorOpening());
        StartCoroutine(PlayFootsteps());
        StartCoroutine(PlayRandomChatter());

        StartCoroutine(PlayLifeSupport());
        StartCoroutine(PlayRadar());
        ///StartCoroutine(PlayshipPulse());
        StartCoroutine(PlayMusic());
        StartCoroutine(PlayShower());
        */

        ///StartCoroutine(ContinuallyAdjustVolume());





    }

    private void Awake()
    {
        linePitchIncrement = (linePitchReduction) / decreaseDuration;


    }

    void Update()
    {
        //Adjust the volume of sounds here (e.g., using Mathf.Lerp)

        ///randomChatter.volume = Mathf.Lerp(0f, 0.8f, Mathf.PingPong(Time.time, 1f));
        ///bgMusic.volume = Mathf.Lerp(0.2f, 0.6f, Mathf.PingPong(Time.time, 1f));
        ///shipPulse.volume = Mathf.Lerp(0f, 0.5f, Mathf.PingPong(Time.time, 1f));


    }

    public void PlayHum()
    {
        // Select a random sound from the array
        int randomIndex = Random.Range(0, shipHums.Length - 1);
        AudioClip randomSound = shipHums[randomIndex];
        shipHum.clip = randomSound;

        // Play the selected random sound
        shipHum.Play();
    }

    void AdjustHumPitch()
    {

        // Check if the duration has reached the desired value
        if (lineScript.duration >= lineController.desiredDuration)
        {
            // Perform any additional actions or stop adjusting the speed
            Debug.Log("Duration reached desired value.");
        }
        else
        {
            // Adjust the pitch 
            shipHum.pitch -= linePitchIncrement;
        }


    }


    ///---------------------------------------

    /*
    IEnumerator PlayDoorOpening()
    {
        while (true)
        {
            float interval = Random.Range(doorOpenMinInterval, doorOpenMaxInterval);
            yield return new WaitForSeconds(interval);

            // Select a random sound from the array
            int randomIndex = Random.Range(0, doorOpenSounds.Length);
            AudioClip randomSound = doorOpenSounds[randomIndex];

            // Play the selected random sound
            doorOpen.clip = randomSound;
            doorOpen.Play();
        }
    }

    IEnumerator PlayRandomChatter()
    {
        while (true)
        {
            float interval = Random.Range(chatterMinInterval, chatterMaxInterval);
            yield return new WaitForSeconds(interval);

            // Select a random sound from the array
            int randomIndex = Random.Range(0, chatterSounds.Length);
            AudioClip randomSound = chatterSounds[randomIndex];

            // Play the selected random sound
            chatter.clip = randomSound;
            chatter.Play();

            //stops the whole sound being played (many of which are 20+ seconds long)
            float timePlay = Random.Range(3, 6);
            yield return new WaitForSeconds(timePlay);
            chatter.Stop();


        }
    }


    IEnumerator PlayFootsteps()
    {
        while (true)
        {
            float interval = Random.Range(footstepsMinInterval, footstepsMaxInterval);
            yield return new WaitForSeconds(interval);


            // Select a random sound from the array
            int randomIndex = Random.Range(0, footstepsSounds.Length);
            AudioClip randomSound = footstepsSounds[randomIndex];

            // Play the selected random sound
            footsteps.clip = randomSound;
            footsteps.Play();

            float timePlay = Random.Range(3, 4);
            yield return new WaitForSeconds(timePlay);
            footsteps.Stop();

        }
    }
    

    IEnumerator PlayLifeSupport()
    {
        while (true)
        {
        
            yield return new WaitForSeconds(lifeSupportInterval);

            // Select a random sound from the array
            int randomIndex = Random.Range(0, lifeSupportSounds.Length);
            AudioClip randomSound = lifeSupportSounds[randomIndex];

            // Play the selected random sound
            lifeSupport.clip = randomSound;
            lifeSupport.Play();

            //stops the whole sound being played (many of which are 20+ seconds long)
            float timePlay = Random.Range(8, 12);
            yield return new WaitForSeconds(timePlay);
            lifeSupport.Stop();

        }
    }


    IEnumerator PlayRadar()
    {
        while (true)
        {
            yield return new WaitForSeconds(radarInterval);
            radar.Play();
        }
    }


    IEnumerator PlayMusic()
    {
        while (true)
        {
            float interval = Random.Range(musicMinInterval, musicMaxInterval);
            yield return new WaitForSeconds(interval);

            // Select a random sound from the array
            int randomIndex = Random.Range(0, musicSounds.Length);
            AudioClip randomSound = musicSounds[randomIndex];

            // Play the selected random sound
            music.clip = randomSound;
            music.Play();

            //stops the whole sound being played (many of which are 60+ seconds long)
            float timePlay = Random.Range(20, 30);
            yield return new WaitForSeconds(timePlay);
            music.Stop();

        }
    }

    IEnumerator PlayShower()
    {
        while (true)
        {
            float interval = Random.Range(showerMinInterval, showerMaxInterval);
            yield return new WaitForSeconds(interval);

            shower.Play();

            //stops the whole sound being played (many of which are 60+ seconds long)
            float timePlay = Random.Range(15, 25);
            yield return new WaitForSeconds(timePlay);
            music.Stop();

        }
    }
    */
    ///---------------------------------------------------

    /*
    IEnumerator ContinuallyAdjustVolume()
    {
        // Get the starting volume of the audio source
        float startVolume = shipPulse.volume;

        // Calculate the target volume
        float targetVolume = startVolume * shipPulseVolumeChangePercentage;

        // Calculate the change in volume per interval
        float calculatedVolumeChange = shipPulseVolumeChangeInterval * volumeAdjustmentInterval;


        while (true)
        {
            // Determine whether to increase or decrease volume based on the target
            if (shipPulse.volume < targetVolume)
            {
                // Increase volume gradually
                shipPulse.volume += calculatedVolumeChange;
            }
            else if (shipPulse.volume > targetVolume)
            {
                // Decrease volume gradually
                shipPulse.volume -= calculatedVolumeChange;
            }

            // Clamp volume to ensure it stays within the valid range (0 to 1)
            shipPulse.volume = Mathf.Clamp(shipPulse.volume, 0f, 1f);

            // Wait for the specified interval before adjusting volume again
            yield return new WaitForSeconds(volumeAdjustmentInterval);
        }
    }
    */
    IEnumerator PlayHydraulics()
    {
        while (true)
        {
            float interval = Random.Range(minHydraulicsInterval, maxHydraulicsInterval);
            yield return new WaitForSeconds(interval);
          
            // Play the selected random sound
            hydraulics.Play();

            //plays a random amount of the sound, some of them are too long as well
            ///float timePlay = Random.Range(30, 40);
            ///yield return new WaitForSeconds(timePlay);
            ///hydraulics.Stop();
        }
    }

    IEnumerator DecreaseVolumeOverTime(AudioSource audioSource)
    {
        float startVolume = audioSource.volume;
        float targetVolume = startVolume * (1.0f - noiseDecreasePercentage);

        float startTime = Time.time;

        while (Time.time - startTime < decreaseDuration)
        {
            float t = (Time.time - startTime) / decreaseDuration;
            audioSource.volume = Mathf.Lerp(startVolume, targetVolume, t);
            yield return null;
        }

        audioSource.volume = targetVolume;
    }

    
    IEnumerator DecreasePitchOverTime(AudioSource audioSource)
    {
        float startPitch = audioSource.pitch;
        float targetPitch = startPitch * (1.0f - pitchDecreasePercentage);

        float startTime = Time.time;

        while (Time.time - startTime < decreaseDuration)
        {
            float t = (Time.time - startTime) / decreaseDuration;
            audioSource.pitch = Mathf.Lerp(startPitch, targetPitch, t);
            yield return null;
        }

        audioSource.pitch = targetPitch;
    }



    private IEnumerator ManageAudioVolumes()
    {
        yield return new WaitForSeconds(0.1f);

        StartCoroutine(DecreaseVolumeOverTime(backgroundAmbience));
        StartCoroutine(DecreaseVolumeOverTime(bgMusic));

        StartCoroutine(DecreaseVolumeOverTime(fan));
        StartCoroutine(DecreaseVolumeOverTime(hydraulics));
        StartCoroutine(DecreaseVolumeOverTime(shipHum));
      

        /*
        StartCoroutine(DecreaseVolumeOverTime(doorOpen));
        StartCoroutine(DecreaseVolumeOverTime(footsteps));
        StartCoroutine(DecreaseVolumeOverTime(chatter));
        StartCoroutine(DecreaseVolumeOverTime(lifeSupport));
        StartCoroutine(DecreaseVolumeOverTime(radar));
        StartCoroutine(DecreaseVolumeOverTime(music));
        StartCoroutine(DecreaseVolumeOverTime(shower));
        */

    }


    private IEnumerator ManageAudioPitches()
    {
        yield return new WaitForSeconds(0.1f);

        StartCoroutine(DecreasePitchOverTime(backgroundAmbience));
        StartCoroutine(DecreasePitchOverTime(bgMusic));

        ///StartCoroutine(DecreasePitchOverTime(fan));
        StartCoroutine(DecreasePitchOverTime(hydraulics));
      
        /*
        StartCoroutine(DecreaseVolumeOverTime(doorOpen));
        StartCoroutine(DecreaseVolumeOverTime(footsteps));
        StartCoroutine(DecreaseVolumeOverTime(chatter));
        StartCoroutine(DecreaseVolumeOverTime(lifeSupport));
        StartCoroutine(DecreaseVolumeOverTime(radar));
        StartCoroutine(DecreaseVolumeOverTime(music));
        StartCoroutine(DecreaseVolumeOverTime(shower));
        */

    }

}
