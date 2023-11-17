using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllLesson : MonoBehaviour
{
    [SerializeField] private Button buttonAllLesson;
    [SerializeField] private Image imageButtonAllLesson;
    [SerializeField] private GameObject mainMenu;

    [SerializeField] private Button buttonMy;
    [SerializeField] private Image imageButtonMy;
    [SerializeField] private GameObject myLessonUI;

    [SerializeField] private Button buttonLesson;
    [SerializeField] private Image imageButtonLesson;
    [SerializeField] private GameObject lessonMenu;

    [SerializeField] private Button butonNotes;
    [SerializeField] private Image imageButtonNotes;
    [SerializeField] private DiaryUI notesMenu;

    [SerializeField] private GameObject allUI;

    [SerializeField] private Button buttonVaccination;
    [SerializeField] GameObject vaccinationUI;

    [SerializeField] private Button buttonMeditation;
    [SerializeField] GameObject meditationUI;

    [SerializeField] private List<LessonButton> listMyLessonButton;

    private void Start()
    {
        notesMenu.OnCloseDiaryUI += NotesMenu_OnCloseDiaryUI;
        buttonAllLesson.image.enabled = false;
        imageButtonAllLesson.gameObject.SetActive(true);
        imageButtonMy.gameObject.SetActive(false);
        imageButtonLesson.gameObject.SetActive(false);
        imageButtonNotes.gameObject.SetActive(false);
        buttonAllLesson.onClick.AddListener(() =>
        {
            allUI.gameObject.SetActive(true);

            buttonAllLesson.image.enabled = false;
            buttonMy.image.enabled = true;
            buttonLesson.image.enabled = true;
            butonNotes.image.enabled = true;

            imageButtonAllLesson.gameObject.SetActive(true);

            imageButtonMy.gameObject.SetActive(false);
            imageButtonLesson.gameObject.SetActive(false);
            imageButtonNotes.gameObject.SetActive(false);

            mainMenu.SetActive(true);

            //myLessonUI.SetActive(false);
            HideMyLessonUI();
            lessonMenu.SetActive(false);
            notesMenu.gameObject.SetActive(false);
        });

        buttonMy.onClick.AddListener(() =>
        {
            buttonAllLesson.image.enabled = true;
            buttonMy.image.enabled = false;
            buttonLesson.image.enabled = true;
            butonNotes.image.enabled = true;

            imageButtonMy.gameObject.SetActive(true);

            imageButtonAllLesson.gameObject.SetActive(false);
            imageButtonLesson.gameObject.SetActive(false);
            imageButtonNotes.gameObject.SetActive(false);

            //myLessonUI.SetActive(true);
            ShowMyLessonUI();
            mainMenu.SetActive(false);
            lessonMenu.SetActive(false);
            notesMenu.gameObject.SetActive(false);
        });

        buttonLesson.onClick.AddListener(() =>
        {

            allUI.gameObject.SetActive(false);

            buttonAllLesson.image.enabled = true;
            buttonMy.image.enabled = true;
            buttonLesson.image.enabled = false;
            butonNotes.image.enabled = true;

            imageButtonLesson.gameObject.SetActive(true);

            imageButtonAllLesson.gameObject.SetActive(false);
            imageButtonMy.gameObject.SetActive(false);
            imageButtonNotes.gameObject.SetActive(false);

            lessonMenu.SetActive(true);

            //myLessonUI.SetActive(false);
            HideMyLessonUI();
            mainMenu.SetActive(false);
            notesMenu.gameObject.SetActive(false);
        });

        butonNotes.onClick.AddListener(() =>
        {
            buttonAllLesson.image.enabled = true;
            buttonMy.image.enabled = true;
            buttonLesson.image.enabled = true;
            butonNotes.image.enabled = false;

            imageButtonNotes.gameObject.SetActive(true);

            imageButtonAllLesson.gameObject.SetActive(false);
            imageButtonMy.gameObject.SetActive(false);
            imageButtonLesson.gameObject.SetActive(false);

            notesMenu.gameObject.SetActive(true);

            lessonMenu.SetActive(false);
            //myLessonUI.SetActive(false);
            HideMyLessonUI();
            mainMenu.SetActive(false);
           
        });
        buttonVaccination.onClick.AddListener(() =>
        {
        vaccinationUI.SetActive(true);
        }
        );
        buttonMeditation.onClick.AddListener(() =>
        {
            meditationUI.SetActive(true);
        }
        );
    }

    private void NotesMenu_OnCloseDiaryUI(object sender, System.EventArgs e)
    {
        allUI.gameObject.SetActive(true);

        buttonAllLesson.image.enabled = false;
        buttonMy.image.enabled = true;
        buttonLesson.image.enabled = true;
        butonNotes.image.enabled = true;

        imageButtonAllLesson.gameObject.SetActive(true);

        imageButtonMy.gameObject.SetActive(false);
        imageButtonLesson.gameObject.SetActive(false);
        imageButtonNotes.gameObject.SetActive(false);

        mainMenu.SetActive(true);

        //myLessonUI.SetActive(false);
        HideMyLessonUI();
        lessonMenu.SetActive(false);
        notesMenu.gameObject.SetActive(false);
    }

    private void ShowMyLessonUI()
    {
        myLessonUI.SetActive(true);
        for (int i = 0; i < listMyLessonButton.Count; i++)
        {
            //if (listMyLessonButton[i].TextNameLessonButton.text != "")
            //{
            //    listMyLessonButton[i].gameObject.SetActive(true);
            //}
            if (listMyLessonButton[i].Number >= 1)
            {
                listMyLessonButton[i].gameObject.SetActive(true);
            }
        }
    }
    private void HideMyLessonUI()
    {
        myLessonUI.SetActive(false);
        for (int i = 0; i < listMyLessonButton.Count; i++)
        {
                listMyLessonButton[i].gameObject.SetActive(false);
        }
    }
}
