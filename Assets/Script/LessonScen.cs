using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LessonScen : MonoBehaviour
{
    [SerializeField] private Button buttonBack;
    private void Start()
    {
        buttonBack.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(0);
        });

    }
}
