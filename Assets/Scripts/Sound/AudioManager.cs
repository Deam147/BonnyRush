using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{

    public AudioMixer music, effects;

    public AudioSource ingameMusic, carrot, coin, dead, velocity;

    public static AudioManager instance;

    [Range(-80,10)]
    public float masterVol, effectsVol;

    public Slider masterSlider, effectsSlider;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        PlayAudio(ingameMusic);

        masterSlider.value = masterVol;
        effectsSlider.value = effectsVol;

        masterSlider.minValue = -80;
        masterSlider.maxValue = 10;

        effectsSlider.minValue = -80;
        effectsSlider.maxValue = 10;


    }

    // Update is called once per frame
    void Update()
    {

        MasterVolume();
        EffectVolume();
    }

    public void MasterVolume()
    {
        music.SetFloat("MasterVolume", masterSlider.value);

    }

    public void EffectVolume()
    {
        effects.SetFloat("EffectsVolume", effectsSlider.value);

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
