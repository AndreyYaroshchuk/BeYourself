using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class LessonButton : MonoBehaviour
{
    public static LessonButton Instance;

    [SerializeField] private Button buttonPlay;
    [SerializeField] private Button buttonPaused;
    [SerializeField] private Button buttonOptionLessonUI;
    [SerializeField] private TMP_Text textVolue;
    [SerializeField] private TMP_Text text;
    [SerializeField] private LessonOptionUI lessonOptionUI;
    [SerializeField] private TMP_Text nameLessonButton;

    private AudioClip audioClip = null;
  
    private bool isPlay;
 

    public string lessonOption;
    public int number = -1;

    
    public TMP_Text TextNameLessonButton { get => nameLessonButton; set => nameLessonButton = value; }
    public int Number { get => number; set => number = value; }


    private void Awake()
    {
        UnityEngine.Application.runInBackground = true;
    }


    [SerializeField] private float time_;

    private float _timeLeft = 0f;
    private bool _timerOn = false;
    private bool timeStop = false;
    private bool oneClicke = false;

    private void OnApplicationPause(bool pause)
    {
        if (pause)
        {
            UnityEngine.Application.runInBackground = true;
        }
    }
    private void Start()
    {

        _timeLeft = time_; //
        _timerOn = true; //

        text.text = FormatTime(Audio.Instance.SetAudioClip(Number).length);
   
        buttonPaused.gameObject.SetActive(false);

        buttonOptionLessonUI.onClick.AddListener(() =>
        {
            if (isPlay == false)
            {
                lessonOptionUI.gameObject.SetActive(true);
                lessonOptionUI.UpdateButtonSave(Number);
                lessonOptionUI.TextLesson.text = TextNameLessonButton.text;
                lessonOptionUI.TextOptionLesson.text = GetLessonOption();
                lessonOptionUI.AudioSource.clip = Audio.Instance.SetAudioClip(Number);
                lessonOptionUI.NumberLessonButton = Number;
            }
        });
        buttonPlay.onClick.AddListener(() =>
        {
            if(oneClicke == false)
            {
                time_ = Audio.Instance.SetAudioClip(Number).length;
                _timeLeft = time_;
                oneClicke = true;

            }
           
            Audio.Instance.Play(Audio.Instance.SetAudioClip(Number));
            audioClip = Audio.Instance.SetAudioClip(Number);
            buttonPlay.gameObject.SetActive(false);
            buttonPaused.gameObject.SetActive(true);
            textVolue.text = Audio.Instance.FormatTime();
            isPlay = true;
        });
        buttonPaused.onClick.AddListener(() =>
        {

            timeStop = false;
            Audio.Instance.StopPlay();
            buttonPlay.gameObject.SetActive(true);
            buttonPaused.gameObject.SetActive(false);
            isPlay = false;
          
        });
        LessonOptionUI.OnClickButtonBack += LessonOptionUI_OnClickButtonBack;
    }

    private void LessonOptionUI_OnClickButtonBack(object sender, System.EventArgs e)
    {
        buttonPaused.gameObject.SetActive(false);
        buttonPlay.gameObject.SetActive(true);
        Audio.Instance.GetAudioSorece().Stop();
    }

    private void Update()
    {

        if (isPlay == true)
        {
            textVolue.text = Audio.Instance.FormatTime();
            //if (_timerOn)
            //{
            //    if (_timeLeft > 0)
            //    {
            //        _timeLeft -= Time.deltaTime;
            //        UpdateTimeText();
            //    }
            //    else
            //    {
            //        _timeLeft = time_;
            //        _timerOn = false;
            //    }
            //}
        }
        ShowButtonPlay();
    }

    private void UpdateTimeText()
    {
        if (_timeLeft < 0)
            _timeLeft = 0;

        float minutes = Mathf.FloorToInt(_timeLeft / 60);
        float seconds = Mathf.FloorToInt(_timeLeft % 60);
        //textVolue.text = minutes + ":" + seconds;
    }
    private string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60F);
        int seconds = Mathf.FloorToInt(time - minutes * 60);
        return string.Format("{0:0}:{1:00}", minutes, seconds);
    }

    public void SetLessonOption(string lessonOption)
    {
        this.lessonOption = lessonOption;
    }
    public string GetLessonOption()
    {
        return this.lessonOption;
    }
    public void ShowButtonPlay()
    {
        if (isPlay == true && audioClip.name != Audio.Instance.GetAudioSorece().clip.name)
        {
            buttonPlay.gameObject.SetActive(true);
            buttonPaused.gameObject.SetActive(false);
            isPlay = false;
            oneClicke = false;   
        }
    }

}
