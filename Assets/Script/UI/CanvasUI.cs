using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CanvasUI : MonoBehaviour
{

    private const string SAVE_FILE_SHOW_START_OPTION_UI = "startOptionUI";

    [SerializeField] private Button buttonFeedback;
    [SerializeField] private FeedbackUI feedbackUI;
    [SerializeField] private GameObject allUI;
    [SerializeField] private Button buttonOpenTelegram;
    [SerializeField] private Button buttonOpenInstagram;
    [SerializeField] private GameObject startOptionUI;
    [SerializeField] Button buttonBuck;

    [SerializeField] private GameObject meditationUI;
    [SerializeField] Button buttonBuckmeditation;


    [SerializeField] private List<LessonButton> listLessonButton;
    [SerializeField] private List<LessonButton> myListLessonButton;

    private void OnApplicationPause(bool pause)
    {
        if (pause)
        {
            UnityEngine.Application.runInBackground = true;
        }
    }
    private void Awake()
    {
        Application.runInBackground = true;
        if (PlayerPrefs.GetInt(SAVE_FILE_SHOW_START_OPTION_UI) == 0)
        {
            startOptionUI.SetActive(true);
        }
        else
        {
            startOptionUI.SetActive(false);
        }
       
        meditationUI.SetActive(false);
        allUI.SetActive(false);
    }
    private void Start()
    {
        UpdateMyLessonUI();
        buttonFeedback.onClick.AddListener(() =>
        {
            feedbackUI.gameObject.SetActive(true);
            allUI.gameObject.SetActive(false);
        });
        buttonOpenTelegram.onClick.AddListener(() =>
        {
            Application.OpenURL("https://t.me/kateryna_go");
        });
        buttonOpenInstagram.onClick.AddListener(() =>
        {
            Application.OpenURL("https://instagram.com/kateryna_goncha_r?igshid=MzRlODBiNWFlZA==");
        });
        if(PlayerPrefs.GetInt(SAVE_FILE_SHOW_START_OPTION_UI) == 0)
        {
            buttonBuck.onClick.AddListener(() =>
            {
                allUI.SetActive(true);
                startOptionUI.SetActive(false);
                PlayerPrefs.SetInt(SAVE_FILE_SHOW_START_OPTION_UI, 1);
                PlayerPrefs.Save();
            });
        }
        else
        {
            allUI.SetActive(true);
        }
      
        buttonBuckmeditation.onClick.AddListener(() =>
        {
            meditationUI.SetActive(false);
        });
        buttonBuck.onClick.AddListener(() =>
        {
            allUI.SetActive(true);
            startOptionUI.SetActive(false);
        });

        LessonOptionUI.OnAddLesson += LessonOptionUI_OnAddLesson;
        LessonOptionUI.OnClearLesson += LessonOptionUI_OnClearLesson;
    }

    private void LessonOptionUI_OnClearLesson(object sender, System.EventArgs e)
    {
        for (int i = 0; i < myListLessonButton.Count; i++)
        {
            myListLessonButton[i].Number = -1;
        }
        UpdateMyLessonUI();
        
    }

    private void LessonOptionUI_OnAddLesson(object sender, System.EventArgs e)
    {
        for (int i = 0; i < myListLessonButton.Count; i++)
        {
            myListLessonButton[i].Number = -1;
        }
        UpdateMyLessonUI();
    }
  
    private void UpdateMyLessonUI()
    {
        for (int i = 0; i < listLessonButton.Count; i++)
        {
            if (listLessonButton[i].Number == PlayerPrefs.GetInt(SaveFile.Instance.SaveLesson_1()))
            {
                for (int j = 0; j < myListLessonButton.Count; j++)
                {
                    if (myListLessonButton[j].Number == -1)
                    {
                        myListLessonButton[j].Number = PlayerPrefs.GetInt(SaveFile.Instance.SaveLesson_1());
                        myListLessonButton[j].TextNameLessonButton.text = listLessonButton[i].TextNameLessonButton.text;
                        myListLessonButton[j].SetLessonOption(listLessonButton[i].GetLessonOption());
                        //myListLessonButton[j].AudioSource.clip = listLessonButton[i].AudioSource.clip;
                        
                        break;
                    }
                }
            }
            else if (listLessonButton[i].Number == PlayerPrefs.GetInt(SaveFile.Instance.SaveLesson_2()))
            {
                for (int j = 0; j < myListLessonButton.Count; j++)
                {
                    if (myListLessonButton[j].Number == -1)
                    {
                        myListLessonButton[j].Number = PlayerPrefs.GetInt(SaveFile.Instance.SaveLesson_2());
                        myListLessonButton[j].TextNameLessonButton.text = listLessonButton[i].TextNameLessonButton.text;
                        myListLessonButton[j].SetLessonOption(listLessonButton[i].GetLessonOption());
                        //myListLessonButton[j].AudioSource.clip = listLessonButton[i].AudioSource.clip;
                        break;
                    }

                }
            }
            else if (listLessonButton[i].Number == PlayerPrefs.GetInt(SaveFile.Instance.SaveLesson_3()))
            {
                for (int j = 0; j < myListLessonButton.Count; j++)
                {
                    if (myListLessonButton[j].Number == -1)
                    {
                        myListLessonButton[j].Number = PlayerPrefs.GetInt(SaveFile.Instance.SaveLesson_3());
                        myListLessonButton[j].TextNameLessonButton.text = listLessonButton[i].TextNameLessonButton.text;
                        myListLessonButton[j].SetLessonOption(listLessonButton[i].GetLessonOption());
                        //myListLessonButton[j].AudioSource.clip = listLessonButton[i].AudioSource.clip;
                        break;
                    }

                }
            }
            else if (listLessonButton[i].Number == PlayerPrefs.GetInt(SaveFile.Instance.SaveLesson_4()))
            {
                for (int j = 0; j < myListLessonButton.Count; j++)
                {
                    if (myListLessonButton[j].Number == -1)
                    {
                        myListLessonButton[j].Number = PlayerPrefs.GetInt(SaveFile.Instance.SaveLesson_4());
                        myListLessonButton[j].TextNameLessonButton.text = listLessonButton[i].TextNameLessonButton.text;
                        myListLessonButton[j].SetLessonOption(listLessonButton[i].GetLessonOption());
                        //myListLessonButton[j].AudioSource.clip = listLessonButton[i].AudioSource.clip;
                        break;
                    }
                }
            }
            else if (listLessonButton[i].Number == PlayerPrefs.GetInt(SaveFile.Instance.SaveLesson_5()))
            {
                for (int j = 0; j < myListLessonButton.Count; j++)
                {
                    if (myListLessonButton[j].Number == -1)
                    {
                        myListLessonButton[j].Number = PlayerPrefs.GetInt(SaveFile.Instance.SaveLesson_5());
                        myListLessonButton[j].TextNameLessonButton.text = listLessonButton[i].TextNameLessonButton.text;
                        myListLessonButton[j].SetLessonOption(listLessonButton[i].GetLessonOption());
                        //myListLessonButton[j].AudioSource.clip = listLessonButton[i].AudioSource.clip;
                        break;
                    }
                }
            }
        }
    }

}


