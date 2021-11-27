using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManagerMenu : MonoBehaviour
{

    public AudioMixer music;

    public AudioSource menuMusic;

    public static AudioManager instance;

    [Range(-80, 10)]
    public float masterVol, effectsVol;



    // Start is called before the first frame update
    void Start()
    {
        PlayAudio(menuMusic);




    }

    // Update is called once per frame
    void Update()
    {


    }





    public void PlayAudio(AudioSource audio)
    {
        audio.Play();
    }

    public void PauseAudio(AudioSource audio)
    {
        audio.Pause();
    }
}