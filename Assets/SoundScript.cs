using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public GameObject drums;
    public GameObject guitar;
    public GameObject piano;
    public GameObject voice;

    [SerializeField]
    AudioSource Adrums;
    [SerializeField]
    AudioSource Aguitar;
    [SerializeField]
    AudioSource Apiano;
    [SerializeField]
    AudioSource Avoice;

    bool played = false;

    void Awake()
    {
        Adrums = drums.gameObject.transform.GetChild(1).GetComponent<AudioSource>();
        Aguitar = guitar.gameObject.transform.GetChild(1).GetComponent<AudioSource>();
        Avoice = voice.gameObject.transform.GetChild(1).GetComponent<AudioSource>();
        Apiano = piano.gameObject.transform.GetChild(1).GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.Debug.Log(Adrums.volume);
    }

    public void PlayMusic()
    {
        if (!played)
        {
            Adrums.Play();
            Aguitar.Play();
            Avoice.Play();
            Apiano.Play();
            played = true;
        }
    }

    public void pianoFull()
    {
        Apiano.volume = 1.0f;
    }
    public void voiceFull()
    {
        Avoice.volume = 1.0f;
    }
    public void drumsFull()
    {
        Adrums.volume = 1.0f;
    }
    public void guitarFull()
    {
        Aguitar.volume = 1.0f;
    }
    public void pianoZero()
    {
        Apiano.volume = 0.0f;
    }
    public void voiceZero()
    {
        Avoice.volume = 0.0f;
    }
    public void drumsZero()
    {
        Adrums.volume = 0.0f;
    }
    public void guitarZero()
    {
        Aguitar.volume = 0.0f;
    }

}
