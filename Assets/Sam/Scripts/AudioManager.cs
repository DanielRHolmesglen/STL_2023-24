using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //below is how we can add similar sounds using the doorOpen as an example randomized, first we add more than one "public AudioSource doorOpen;", then make method and call that method e.g. where doorOpen.Play(); is, instead we call the below, by stating doorOpens(); and inside that function it does the randomizing and the .Play
    //I don't know how but this can be done in a [Serializedfield] probably

    //private void doorOpens()
    //{
    //int rand = Random.Range (0, 4);
    //if (rand == 0)
    // {
    //  doorOpen.Play();
    // }
    //   if (rand == 1)
    //   {
    //    doorOpen1.Play();
    //   }
    //}

    //audio sources
    public AudioSource backgroundAmbience;    
    public AudioSource shipHum;
    public AudioSource waterPipe;
    
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
    public float footstepsMinInterval = 10f;
    public float footstepsMaxInterval = 20f;
    public float doorOpenMinInterval = 10f;
    public float doorOpenMaxInterval = 15f;
    public float chatterMinInterval = 15f;
    public float chatterMaxInterval = 25f;
    public float musicMinInterval = 30f;
    public float musicMaxInterval = 45f;
    public float showerMinInterval = 40f;
    public float showerMaxInterval = 60f;


    //Periodically played sounds (every X seconds)
    public float lifeSupportInterval = 25f;
    public float radarInterval = 15f;
    ///public float waterPipeInterval = 40f;
    

    //some specific volume adjustments
    public float waterPipeVolumePercentage = 0.5f; // Target volume percentage (0 to 1)
    public float waterPipeChangeSpeed = 0.5f; // Volume change speed per second




    //Lowering overall volume
    public float noiseReductionDelay = 30f; //how long before it starts to reduce sound
    public float decreasePercentage = 0.50f; // The total percentage by which to decrease the volume
    public float decreaseDuration = 300f;  // The duration over which to decrease the volume


    void Start()
    {
        //start playing background looping sounds 
        backgroundAmbience.loop = true;
        backgroundAmbience.Play();

        shipHum.loop = true;
        shipHum.Play();

        waterPipe.loop = true;
        waterPipe.Play();


        //start playing periodical/random sounds
        StartCoroutine(PlayDoorOpening());
        StartCoroutine(PlayFootsteps());
        StartCoroutine(PlayRandomChatter());

        StartCoroutine(PlayLifeSupport());
        StartCoroutine(PlayRadar());
        ///StartCoroutine(PlayWaterPipe());
        StartCoroutine(PlayMusic());
        StartCoroutine(PlayShower());



        StartCoroutine(ContinuallyAdjustVolume());


        //start gradually decreasing volumes
        StartCoroutine(manageAudioVolumes());


    }

    void Update()
    {
        //Adjust the volume of sounds here (e.g., using Mathf.Lerp)

        ///randomChatter.volume = Mathf.Lerp(0f, 0.8f, Mathf.PingPong(Time.time, 1f));
        shipHum.volume = Mathf.Lerp(0.2f, 0.6f, Mathf.PingPong(Time.time, 1f));
        waterPipe.volume = Mathf.Lerp(0f, 0.5f, Mathf.PingPong(Time.time, 1f));


    }


    IEnumerator ContinuallyAdjustVolume()
    {
        // Get the starting volume of the audio source
        float startVolume = waterPipe.volume;

        // Calculate the target volume
        float targetVolume = startVolume * waterPipeVolumePercentage;

        while (true)
        {
            // Calculate the change in volume per frame
            float volumeChangePerFrame = waterPipeChangeSpeed * Time.deltaTime;

            // Determine whether to increase or decrease volume based on the target
            if (waterPipe.volume < targetVolume)
            {
                // Increase volume gradually
                waterPipe.volume += volumeChangePerFrame;
            }
            else if (waterPipe.volume > targetVolume)
            {
                // Decrease volume gradually
                waterPipe.volume -= volumeChangePerFrame;
            }

            // Clamp volume to ensure it stays within the valid range (0 to 1)
            waterPipe.volume = Mathf.Clamp(waterPipe.volume, 0f, 1f);

            // Wait for the next frame
            yield return null;
        }
    }

    ///---------------------------------------


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

 ///---------------------------------------------------

    IEnumerator DecreaseVolumeOverTime(AudioSource audioSource)
    {
        float startVolume = audioSource.volume;
        float targetVolume = startVolume * (1.0f - decreasePercentage);

        float startTime = Time.time;

        while (Time.time - startTime < decreaseDuration)
        {
            float t = (Time.time - startTime) / decreaseDuration;
            audioSource.volume = Mathf.Lerp(startVolume, targetVolume, t);
            yield return null;
        }

        audioSource.volume = targetVolume;
    }


    private IEnumerator manageAudioVolumes()
    {
        yield return new WaitForSeconds(noiseReductionDelay);

        StartCoroutine(DecreaseVolumeOverTime(backgroundAmbience));
        StartCoroutine(DecreaseVolumeOverTime(shipHum));
        StartCoroutine(DecreaseVolumeOverTime(waterPipe));

        StartCoroutine(DecreaseVolumeOverTime(doorOpen));
        StartCoroutine(DecreaseVolumeOverTime(footsteps));
        StartCoroutine(DecreaseVolumeOverTime(chatter));
        StartCoroutine(DecreaseVolumeOverTime(lifeSupport));
        StartCoroutine(DecreaseVolumeOverTime(radar));
        StartCoroutine(DecreaseVolumeOverTime(music));
        StartCoroutine(DecreaseVolumeOverTime(shower));


    }
}
