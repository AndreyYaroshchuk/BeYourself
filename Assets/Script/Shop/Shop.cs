using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.UIElements;

public class Shop : MonoBehaviour
{
   [SerializeField] private List<GameObject> listShopGameObject;

    private void Start()
    {
        UpdateShop();
    }
    public void OnShopCompleted(Product product)
    {
        switch(product.definition.id)
        {
            case "com.serbull.iaptutorial.lesson1":
                listShopGameObject[0].SetActive(false);
                PlayerPrefs.SetInt("com.serbull.iaptutorial.lesson1", 1);
                break;
            case "com.serbull.iaptutorial.lesson3":
                listShopGameObject[1].SetActive(false);
                PlayerPrefs.SetInt("com.serbull.iaptutorial.lesson3", 1);
                break;
            case "com.serbull.iaptutorial.lesson5":
                listShopGameObject[2].SetActive(false);
                PlayerPrefs.SetInt("com.serbull.iaptutorial.lesson5", 1);
                break;
            case "com.serbull.iaptutorial.lesson7":
                listShopGameObject[3].SetActive(false);
                PlayerPrefs.SetInt("com.serbull.iaptutorial.lesson7", 1);
                break;
            case "com.serbull.iaptutorial.lesson8":
                listShopGameObject[4].SetActive(false);
                PlayerPrefs.SetInt("com.serbull.iaptutorial.lesson8", 1);
                break;
            case "com.serbull.iaptutorial.lesson9":
                listShopGameObject[5].SetActive(false);
                PlayerPrefs.SetInt("com.serbull.iaptutorial.lesson9", 1);
                break;
            case "com.serbull.iaptutorial.lesson10":
                listShopGameObject[6].SetActive(false);
                PlayerPrefs.SetInt("com.serbull.iaptutorial.lesson10", 1);
                break;
            case "com.serbull.iaptutorial.lesson12":
                listShopGameObject[7].SetActive(false);
                PlayerPrefs.SetInt("com.serbull.iaptutorial.lesson12", 1);
                break;
            case "com.serbull.iaptutorial.lesson13":
                listShopGameObject[8].SetActive(false);
                PlayerPrefs.SetInt("com.serbull.iaptutorial.lesson13", 1);
                break;
            case "com.serbull.iaptutorial.lesson14":
                listShopGameObject[9].SetActive(false);
                PlayerPrefs.SetInt("com.serbull.iaptutorial.lesson14", 1);
                break;
            case "com.serbull.iaptutorial.lesson15":
                listShopGameObject[10].SetActive(false);
                PlayerPrefs.SetInt("com.serbull.iaptutorial.lesson15", 1);
                break;
            case "com.serbull.iaptutorial.lesson16":
                listShopGameObject[11].SetActive(false);
                PlayerPrefs.SetInt("com.serbull.iaptutorial.lesson16", 1);
                break;
            case "com.serbull.iaptutorial.lesson17":
                listShopGameObject[12].SetActive(false);
                PlayerPrefs.SetInt("com.serbull.iaptutorial.lesson17", 1);
                break;
            case "com.serbull.iaptutorial.lesson19":
                listShopGameObject[13].SetActive(false);
                PlayerPrefs.SetInt("com.serbull.iaptutorial.lesson19", 1);
                break;
            case "com.serbull.iaptutorial.lesson20":
                listShopGameObject[14].SetActive(false);
                PlayerPrefs.SetInt("com.serbull.iaptutorial.lesson20", 1);
                break;
            case "com.serbull.iaptutorial.lessonAll22":
                for (int i = 0; i < listShopGameObject.Count ; i++)
                {
                    listShopGameObject[i].SetActive(false);
                }
                PlayerPrefs.SetInt("com.serbull.iaptutorial.lessonAll22", 1);
                break;

        }

    }
    private void UpdateShop()
    {
        if(PlayerPrefs.GetInt("com.serbull.iaptutorial.lesson1") == 1)
        {
            listShopGameObject[0].SetActive(false);
        }
        if (PlayerPrefs.GetInt("com.serbull.iaptutorial.lesson3") == 1)
        {
            listShopGameObject[1].SetActive(false);
        }
        if (PlayerPrefs.GetInt("com.serbull.iaptutorial.lesson5") == 1)
        {
            listShopGameObject[2].SetActive(false);
        }
        if (PlayerPrefs.GetInt("com.serbull.iaptutorial.lesson7") == 1)
        {
            listShopGameObject[3].SetActive(false);
        }
        if (PlayerPrefs.GetInt("com.serbull.iaptutorial.lesson8") == 1)
        {
            listShopGameObject[4].SetActive(false);
        }
        if (PlayerPrefs.GetInt("com.serbull.iaptutorial.lesson9") == 1)
        {
            listShopGameObject[5].SetActive(false);
        }
        if (PlayerPrefs.GetInt("com.serbull.iaptutorial.lesson10") == 1)
        {
            listShopGameObject[6].SetActive(false);
        }
        if (PlayerPrefs.GetInt("com.serbull.iaptutorial.lesson12") == 1)
        {
            listShopGameObject[7].SetActive(false);
        }
        if (PlayerPrefs.GetInt("com.serbull.iaptutorial.lesson13") == 1)
        {
            listShopGameObject[8].SetActive(false);
        }
        if (PlayerPrefs.GetInt("com.serbull.iaptutorial.lesson14") == 1)
        {
            listShopGameObject[9].SetActive(false);
        }
        if (PlayerPrefs.GetInt("com.serbull.iaptutorial.lesson15") == 1)
        {
            listShopGameObject[10].SetActive(false);
        }
        if (PlayerPrefs.GetInt("com.serbull.iaptutorial.lesson16") == 1)
        {
            listShopGameObject[11].SetActive(false);
        }
        if (PlayerPrefs.GetInt("com.serbull.iaptutorial.lesson17") == 1)
        {
            listShopGameObject[12].SetActive(false);
        }
        if (PlayerPrefs.GetInt("com.serbull.iaptutorial.lesson19") == 1)
        {
            listShopGameObject[13].SetActive(false);
        }
        if (PlayerPrefs.GetInt("com.serbull.iaptutorial.lesson20") == 1)
        {
            listShopGameObject[14].SetActive(false);
        }
        if (PlayerPrefs.GetInt("com.serbull.iaptutorial.lessonAll22") == 1)
        {
            for (int i = 0; i < listShopGameObject.Count; i++)
            {
                listShopGameObject[i].SetActive(false);
            }

        }
    }
}
