
using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Slider = UnityEngine.UI.Slider;

public class ScrolAudio : MonoBehaviour
{
    public event EventHandler OnClickScrol;

    public AudioSource audioSource;
    public LessonOptionUI lessonOptionUI;
    public Slider mySlider;
    public TextMeshProUGUI textTime;
    public TextMeshProUGUI textStartTime;
    public bool isPlay = false;
    private bool isStartScrol = false;


    private void Start()
    {
        mySlider.maxValue = audioSource.clip.length;

        textStartTime.text = "/" + FormatTime(audioSource.clip.length);

        LessonOptionUI.OnClickButtonBack += LessonOptionUI_OnClickButtonBack;
    }

    private void LessonOptionUI_OnClickButtonBack(object sender, System.EventArgs e)
    {
        isPlay = false;
        audioSource.Pause();
        audioSource.time = 0;
        mySlider.value = 0;
        audioSource.clip = null;
    }


    private void Update()
    {
        textTime.text = FormatTime(audioSource.time);
        if (isPlay == false)
        {
            mySlider.value = audioSource.time;
        }
    }
    private string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60F);
        int seconds = Mathf.FloorToInt(time - minutes * 60);
        return string.Format("{0:0}:{1:00}", minutes, seconds);
    }

    public void ScrolEnter()
    {
        if (Audio.Instance.GetAudioSorece().isPlaying)
        {
            Audio.Instance.GetAudioSorece().Stop();
        }

        isPlay = true;
        audioSource.Pause();
        if(isStartScrol == false)
        {
            isStartScrol = true;
            OnClickScrol?.Invoke(this, EventArgs.Empty);
        }
    }
    public void ScrolExit()
    {
        if (Audio.Instance.GetAudioSorece().isPlaying)
        {
            Audio.Instance.GetAudioSorece().Stop();
        }
        if(mySlider.value < audioSource.clip.length)
        {
            audioSource.time = mySlider.value;
        }
        audioSource.Play();
        isPlay = false;
    }

}

