using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DiaryUI : MonoBehaviour
{
    private static string FILE_INPUT_FIELD = "InputField";

    public event EventHandler OnCloseDiaryUI;

    [SerializeField] private Button button;
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private Button openOptionUI;
    [SerializeField] private Button closeOptionUI;
    [SerializeField] private GameObject optionUI;

    

    private void Awake()
    {
        gameObject.SetActive(true);
    }
    private void Start()
    {
        gameObject.SetActive(false);
        optionUI.SetActive(false);  
        if (PlayerPrefs.GetString(FILE_INPUT_FIELD) != "")
        {
            inputField.text = PlayerPrefs.GetString(FILE_INPUT_FIELD);
        }
        button.onClick.AddListener(() =>
        {
            OnCloseDiaryUI?.Invoke(this, EventArgs.Empty);
            PlayerPrefs.SetString(FILE_INPUT_FIELD, inputField.text);
            gameObject.SetActive(false);
        });
        openOptionUI.onClick.AddListener(() =>
        {
            optionUI.gameObject.SetActive(true);
        });
        closeOptionUI.onClick.AddListener(() =>
        {
            optionUI.gameObject.SetActive(false);
        });
    }
}
