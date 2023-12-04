using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Audio : MonoBehaviour
{
    public static Audio Instance;


    //public AudioMixer audioMixer;
    [SerializeField] private AudioSource audioSource;
 
    [SerializeField] private List<AudioClip> clipList;

    private float time;


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
    private void Start()
    {
        audioSource.loop = true;
        audioSource.ignoreListenerPause = true;
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
    public string FormatTime()
    {
        time = audioSource.time;
        int minutes = Mathf.FloorToInt(time / 60F);
        int seconds = Mathf.FloorToInt(time - minutes * 60);
        return string.Format("{0:0}:{1:00}", minutes, seconds);
    }

}
