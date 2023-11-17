using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LessonUI : MonoBehaviour
{
    [SerializeField] private Button button;
    private void Start()
    {
        gameObject.SetActive(false);
        button.onClick.AddListener(() =>
        {
            gameObject.SetActive(false);
        });
    }
}
