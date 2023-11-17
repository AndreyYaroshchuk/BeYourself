using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class MoveMainMenu : MonoBehaviour
{
    public static MoveMainMenu Instance;

    [SerializeField] private List<LessonButton> listLessonBatton;
    [SerializeField] private GameObject topPart;
    [SerializeField] private GameObject upPart;

    private float moveUp = 1f;
    private float moveDown = 1f;

    private bool isGetTouch = false;
    private Vector2 vectorGetTouch;

    private void Awake()
    {
        Instance = this;    
    }
    private void Update()
    {
        Move();
        for (int i = 0; i < listLessonBatton.Count; i++)
        {
            if (listLessonBatton[i].gameObject.transform.position.y >= topPart.transform.position.y )
            {
                listLessonBatton[i].gameObject.SetActive(false);
            }
            if (listLessonBatton[i].gameObject.transform.position.y <= topPart.transform.position.y)
            {
                listLessonBatton[i].gameObject.SetActive(true);
            }

        }
    }
    private void Move()
    {
        if (Input.GetTouch(0).phase == TouchPhase.Began)
        {
            isGetTouch = true;
            vectorGetTouch = Input.GetTouch(0).position;
        }
        else if (Input.GetTouch(0).phase == TouchPhase.Canceled || Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            isGetTouch = false;
        }
        if (Input.GetTouch(0).position.y >= vectorGetTouch.y && isGetTouch == true) 
        {
            Vector3 vector3 = new Vector3(0, transform.position.y + moveUp, 0);
            transform.position += vector3 * Time.deltaTime;      
        }
        if (Input.GetTouch(0).position.y <= vectorGetTouch.y && isGetTouch == true )
        {
            transform.position -= new Vector3(0, transform.position.y - moveDown, 0) * Time.deltaTime; 
        }

    }

}
