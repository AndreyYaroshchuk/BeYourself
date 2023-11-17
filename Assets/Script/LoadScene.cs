using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{

    public TextMeshProUGUI textLoad;
    public Button btn;


    private AsyncOperation loadingScene;
    private bool loadingClick = false;
    private void Awake()
    {
        //DontDestroyOnLoad(gameObject);
    }
    private void Start()
    {
        //btn.onClick.AddListener(() =>
        //{
        //    StartLoad("MainMenu");
        //    loadingClick = true;
        //});
        StartLoad("MainMenu");

    }
    private void Update()
    {
        if (loadingClick == true)
        {
            textLoad.text = Mathf.RoundToInt(loadingScene.progress * 100).ToString() + " %";
            if (loadingScene.isDone == false)
            {
                OnOver();
            }
        }
    }
    private void StartLoad(string sceneName)
    {

        loadingScene = SceneManager.LoadSceneAsync(sceneName);
        loadingScene.allowSceneActivation = false;
        loadingClick = true;
    }
    private void OnOver()
    {
        loadingScene.allowSceneActivation = true;
    }

    //public static LoadScene Instance;
    //public TextMeshProUGUI textLoad;
    //public Button btn;


    //private void Awake()
    //{
    //    if (Instance == null)
    //    {
    //        Instance = this;
    //        DontDestroyOnLoad(gameObject);
    //    }
    //    else
    //    {
    //        Destroy(gameObject);
    //    }
    //}

    //private void Start()
    //{
    //    btn.onClick.AddListener(() =>
    //    {
    //        LoadScenes("Test");
    //    });
    //}
    //public async void LoadScenes(string sceneName)
    //{
    //    var scene = SceneManager.LoadSceneAsync(sceneName);
    //    scene.allowSceneActivation = false;

    //    do
    //    {
    //        await Task.Delay(100);
    //        textLoad.text = Mathf.RoundToInt(scene.progress * 100).ToString() + " %";
    //    }
    //    while (scene.progress < 0.9f);

    //    await Task.Delay(1000);
    //    scene.allowSceneActivation = true;


    //}

}

