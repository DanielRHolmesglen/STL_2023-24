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


    public AudioSource backgroundAmbience;    
    public AudioSource shipHum;    
    public AudioSource doorOpen;    
    public AudioSource footsteps;    
    public AudioSource randomChatter;        
    public AudioSource airCon;
    public AudioSource radar;
    public AudioSource waterPipe;



    //randomly played sounds (every bewteen X and Y seconds)
    public float footstepsMinInterval = 12f;
    public float footstepsMaxInterval = 12f;
    public float doorOpenMinInterval = 15f;
    public float doorOpenMaxInterval = 30f;
    public float chatterMinInterval = 15f;
    public float chatterMaxInterval = 30f;


    //Periodically played sounds (every X seconds)
    public float airConInterval = 25f;
    public float radarInterval = 15f;
    public float waterPipeInterval = 40f;


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

        ///start playing periodical/random sounds
        StartCoroutine(PlayDoorOpening());
        StartCoroutine(PlayFootsteps());
        StartCoroutine(PlayRandomChatter());

        StartCoroutine(PlayAirCon());
        StartCoroutine(PlayRadar());
        StartCoroutine(PlayWaterPipe());




        StartCoroutine(manageAudioVolumes());


    }

    void Update()
    {
        //Adjust the volume of sounds here (e.g., using Mathf.Lerp)

        //randomChatter.volume = Mathf.Lerp(0f, 0.8f, Mathf.PingPong(Time.time, 1f));
        ///shipHum.volume = Mathf.Lerp(0.2f, 0.8f, Mathf.PingPong(Time.time, 1f));

    }

    IEnumerator PlayDoorOpening()
    {
        while (true)
        {
            float interval = Random.Range(doorOpenMinInterval, doorOpenMaxInterval);

            yield return new WaitForSeconds(interval);

            doorOpen.Play();
        }
    }

    IEnumerator PlayRandomChatter()
    {
        while (true)
        {
            float interval = Random.Range(chatterMinInterval, chatterMaxInterval);
            yield return new WaitForSeconds(interval);
            doorOpen.Play();

            float timePlay = Random.Range(3, 6);
            yield return new WaitForSeconds(timePlay);
            doorOpen.Stop();


        }
    }


    IEnumerator PlayFootsteps()
    {
        while (true)
        {
            float interval = Random.Range(footstepsMinInterval, footstepsMaxInterval);

            yield return new WaitForSeconds(interval);
            footsteps.Play();
        }
    }
    

    IEnumerator PlayAirCon()
    {
        while (true)
        {
            yield return new WaitForSeconds(airConInterval);            
            airCon.Play();

            yield return new WaitForSeconds(10.0f);
            airCon.Stop();

        }
    }

    IEnumerator PlayWaterPipe()
    {
        while (true)
        {
            yield return new WaitForSeconds(waterPipeInterval);
            waterPipe.Play();

            float timePlay = Random.Range(4, 8);
            yield return new WaitForSeconds(timePlay);
            doorOpen.Stop();
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
        StartCoroutine(DecreaseVolumeOverTime(doorOpen));
        StartCoroutine(DecreaseVolumeOverTime(footsteps));
        StartCoroutine(DecreaseVolumeOverTime(randomChatter));
        StartCoroutine(DecreaseVolumeOverTime(airCon));
        StartCoroutine(DecreaseVolumeOverTime(radar));
        StartCoroutine(DecreaseVolumeOverTime(waterPipe));





    }
}
