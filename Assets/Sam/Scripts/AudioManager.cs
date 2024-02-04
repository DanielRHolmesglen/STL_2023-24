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
    //public AudioSource footsteps;    
    //public AudioSource randomChatter;        
    public AudioSource airCon;

    //public float footstepsInterval = 12f;
    public float doorOpenMinInterval = 15f;
    public float doorOpenMaxInterval = 30f;
    public float airConInterval = 35f;

    public float noiseReductionDelay = 20f;
    public float decreasePercentage = 0.50f; // The total percentage by which to decrease the volume
    public float decreaseDuration = 20f;  // The duration over which to decrease the volume


    void Start()
    {
        ///start playing background looping sounds 
        backgroundAmbience.loop = true;
        backgroundAmbience.Play();

        shipHum.loop = true;
        shipHum.Play();

        ///start corroutines
        StartCoroutine(PlayDoorOpening());
        //StartCoroutine(PlayFootsteps());
        StartCoroutine(PlayAirCon());


        StartCoroutine(manageAudioVolumes());






    }

    void Update()
    {
        /// Adjust the volume of sounds here (e.g., using Mathf.Lerp)
        
        //randomChatter.volume = Mathf.Lerp(0.2f, 0.8f, Mathf.PingPong(Time.time, 1f));
        shipHum.volume = Mathf.Lerp(0.2f, 0.8f, Mathf.PingPong(Time.time, 1f));

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

    /*
    IEnumerator PlayFootsteps()
    {
        while (true)
        {
            nextFootstepsTime = footstepsInterval;

            yield return new WaitForSeconds(footstepsInterval);
            footsteps.Play();
        }
    }
    */

    IEnumerator PlayAirCon()
    {
        while (true)
        {
            yield return new WaitForSeconds(airConInterval);            
            airCon.Play();
        }
    }

    IEnumerator DecreaseVolumeOverTime(AudioSource audioSource)
    {
        float startVolume = audioSource.volume;
        float targetVolume = startVolume * (1.0f - decreasePercentage); // Calculate the target volume

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
        StartCoroutine(DecreaseVolumeOverTime(airCon));


    }
}
