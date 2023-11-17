using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SaveFile : MonoBehaviour
{

    public static SaveFile Instance;

    private const string SAVE_LESSON_1 = "save_lesson_1";
    private const string SAVE_LESSON_2 = "save_lesson_2";
    private const string SAVE_LESSON_3 = "save_lesson_3";
    private const string SAVE_LESSON_4 = "save_lesson_4";
    private const string SAVE_LESSON_5 = "save_lesson_5";

    public bool dele;



    


    private void Awake()
    {
        Instance = this;
       
    }
    private void Update()
    {if (dele)
        {
            PlayerPrefs.DeleteAll();
        }
    }
   
    public string SaveLesson_1()
    {
        return SAVE_LESSON_1;
    }
    public string SaveLesson_2()
    {
        return SAVE_LESSON_2;
    }
    public string SaveLesson_3()
    {
        return SAVE_LESSON_3;
    }
    public string SaveLesson_4()
    {
        return SAVE_LESSON_4;
    }
    public string SaveLesson_5()
    {
        return SAVE_LESSON_5;
    }
  
}
