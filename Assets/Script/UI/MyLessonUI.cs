using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MyLessonUI : MonoBehaviour
{
    [SerializeField] private LessonButton lessonButton;

    private bool isFilled = true;
    
   
    private string lessonDescription;
    public bool IsFilled { get => isFilled; set => isFilled = value; }
    public string LessonDescription { get => lessonDescription; set => lessonDescription = value; }


    private void Start()
    {
        Hide();
 
    }

    public void LessonName(string name)
    {
        lessonButton.TextNameLessonButton.text = name;
    }
    //public void LessonAudioSourse( AudioClip audioClip)
    //{
    //    lessonButton.AudioSource.clip = audioClip;
    //}
    public void Show()
    {
        lessonButton.gameObject.SetActive(true);
    }
    public void Hide()
    {
        lessonButton.gameObject.SetActive(false);
    }
    
}
