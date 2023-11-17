using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void Start()
    {
        // ѕредотвращаем переход в сп€щий режим
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }


}
