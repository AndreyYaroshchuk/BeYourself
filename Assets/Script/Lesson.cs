using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Lesson : MonoBehaviour
{
    [SerializeField] private int lessonNomber;
    [SerializeField] private Button buttonLesson;

   
    private void Start()
    {
        buttonLesson.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(lessonNomber);
        });
    }
}
