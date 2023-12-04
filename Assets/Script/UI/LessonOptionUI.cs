using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;



public class LessonOptionUI : MonoBehaviour
{

    public static event EventHandler OnAddLesson;
    public static event EventHandler OnClearLesson;
    public event EventHandler OnRestartAudio;
    public event EventHandler OnClickButtonBack;


    [SerializeField] private ScrolAudio scrolAudio;
    [SerializeField] private Button buttonPlay;
    [SerializeField] private Button buttonRestartPlay;
    [SerializeField] private Button buttonSave;
    [SerializeField] private Button back;
    [SerializeField] private Button buttonPaused;
    [SerializeField] private TextMeshProUGUI textLesson;
    [SerializeField] private TextMeshProUGUI textOptionLesson;


    [SerializeField] private List<MyLessonUI> myLessonListUI;
    [SerializeField] private GameObject myLessonUI;

    public AudioSource audioSource;

    public Sprite spriteButtonSave;

    private int numberLessonButton;

    private int countSave = 0;



    public TextMeshProUGUI TextLesson { get => textLesson; set => textLesson = value; }
    public TextMeshProUGUI TextOptionLesson { get => textOptionLesson; set => textOptionLesson = value; }
    public AudioSource AudioSource { get => audioSource; set => audioSource = value; }
    public int NumberLessonButton { get => numberLessonButton; set => numberLessonButton = value; }

    private void Start()
    {
        buttonPaused.gameObject.SetActive(false);
        back.onClick.AddListener(() =>
        {
            OnClickButtonBack?.Invoke(this, EventArgs.Empty);
            buttonSave.gameObject.SetActive(true);
            buttonPlay.gameObject.SetActive(true);
            gameObject.SetActive(false);
            buttonPaused.gameObject.SetActive(false);

            PlayerPrefs.Save();
        });
        buttonPlay.onClick.AddListener(() =>
        {
            audioSource.Play();
            buttonPaused.gameObject.SetActive(true);
            buttonPlay.gameObject.SetActive(false);
        });
        buttonRestartPlay.onClick.AddListener(() =>
        {
            //OnRestartAudio?.Invoke(this, EventArgs.Empty);
            //audioSource.PlayScheduled(0);
            audioSource.time -= 15f;
        });
        buttonPaused.onClick.AddListener(() =>
        {
            audioSource.Pause();
            buttonPaused.gameObject.SetActive(false);
            buttonPlay.gameObject.SetActive(true);
        });
        buttonSave.onClick.AddListener(() =>
        {

            AddLesson();

        });

        scrolAudio.OnClickScrol += ScrolAudio_OnClickScrol;
    }

    private void ScrolAudio_OnClickScrol(object sender, EventArgs e)
    {
        buttonPlay.gameObject.SetActive(false);
        buttonPaused.gameObject.SetActive(true);
    }

    private void AddLesson()
    {
        if (GetFile(NumberLessonButton) == true)
        {
            ClearFile(NumberLessonButton);
            OnClearLesson?.Invoke(this, EventArgs.Empty);
            buttonSave.GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);

            return;
        }
        for (int i = 0; i < myLessonListUI.Count; i++)
        {

            if (myLessonListUI[i].IsFilled == true && GetFile(NumberLessonButton) == false)
            {
                myLessonListUI[i].IsFilled = false;
                buttonSave.GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.5f);
                SavesFile(NumberLessonButton);
                OnAddLesson?.Invoke(this, EventArgs.Empty);
                return;
            }
        }

    }
    private void SavesFile(int number)
    {
        switch (countSave)
        {
            case 0:
                PlayerPrefs.SetInt(SaveFile.Instance.SaveLesson_1(), number);
                break;
            case 1:
                PlayerPrefs.SetInt(SaveFile.Instance.SaveLesson_2(), number);
                break;
            case 2:
                PlayerPrefs.SetInt(SaveFile.Instance.SaveLesson_3(), number);
                break;
            case 3:
                PlayerPrefs.SetInt(SaveFile.Instance.SaveLesson_4(), number);
                break;
            case 4:
                PlayerPrefs.SetInt(SaveFile.Instance.SaveLesson_5(), number);
                break;
        }
        countSave++;
    }
    private void ClearFile(int number)
    {
        if (PlayerPrefs.GetInt(SaveFile.Instance.SaveLesson_1()) == number)
        {
            myLessonListUI[0].IsFilled = true;
            PlayerPrefs.SetInt(SaveFile.Instance.SaveLesson_1(), 0);
        }
        if (PlayerPrefs.GetInt(SaveFile.Instance.SaveLesson_2()) == number)
        {
            myLessonListUI[1].IsFilled = true;
            PlayerPrefs.SetInt(SaveFile.Instance.SaveLesson_2(), 0);
        }
        if (PlayerPrefs.GetInt(SaveFile.Instance.SaveLesson_3()) == number)
        {
            myLessonListUI[2].IsFilled = true;
            PlayerPrefs.SetInt(SaveFile.Instance.SaveLesson_3(), 0);
        }
        if (PlayerPrefs.GetInt(SaveFile.Instance.SaveLesson_4()) == number)
        {
            myLessonListUI[3].IsFilled = true;
            PlayerPrefs.SetInt(SaveFile.Instance.SaveLesson_4(), 0);
        }
        if (PlayerPrefs.GetInt(SaveFile.Instance.SaveLesson_5()) == number)
        {
            myLessonListUI[4].IsFilled = true;
            PlayerPrefs.SetInt(SaveFile.Instance.SaveLesson_4(), 0);
        }
    }
    private bool GetFile(int number)
    {

        if (number == PlayerPrefs.GetInt(SaveFile.Instance.SaveLesson_1()) || number == PlayerPrefs.GetInt(SaveFile.Instance.SaveLesson_2())
            || number == PlayerPrefs.GetInt(SaveFile.Instance.SaveLesson_3()) || number == PlayerPrefs.GetInt(SaveFile.Instance.SaveLesson_4())
              || number == PlayerPrefs.GetInt(SaveFile.Instance.SaveLesson_5()))
        {
            return true;
        }

        return false;

    }
    public void UpdateButtonSave(int number)
    {
        if (GetFile(number) == true)
        {
            buttonSave.GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.5f);
        }
        else
        {
            buttonSave.GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
        }
    }
}
