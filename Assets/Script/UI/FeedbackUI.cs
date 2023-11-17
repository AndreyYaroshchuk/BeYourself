using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeedbackUI : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private GameObject allUI;
    private void Start()
    {
        gameObject.SetActive(false);
        button.onClick.AddListener(() =>
        {
            gameObject.SetActive(false);
            allUI.gameObject.SetActive(true);
        });
    }
}
