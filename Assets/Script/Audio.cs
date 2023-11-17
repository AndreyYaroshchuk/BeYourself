using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Audio : MonoBehaviour
{
    public static Audio Instance;


    public AudioMixer audioMixer;
    [SerializeField] private AudioSource audioSource;
 
    [SerializeField] private List<AudioClip> clipList;

    private void OnApplicationPause(bool pause)
    {
        if (pause)
        {
            Application.runInBackground = true;
        }
    }
    private void Awake()
    {
        Application.runInBackground = true;
        Instance = this;
    }
    public AudioClip SetAudioClip(int i)
    {
        return clipList[i - 1]; 
    }
    public AudioSource GetAudioSorece()
    {
        return audioSource;
    }
    public void Play(AudioClip clip)
    {
        audioSource.clip = clip;    
        audioSource.Play();
    }
    public void StopPlay()
    {
        audioSource.Pause();
    }
    
}
