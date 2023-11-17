using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLessonButton : MonoBehaviour
{
    [SerializeField] private List<LessonButton> lisstLessonButton;

    public float sdeepTouch = 2f;

    private float hideUp = 2.7f;
    private float hideDown = -3.3f;
    private float stopMoveDown;

    private void Start()
    {
        stopMoveDown = transform.position.y;
    }
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Swipe();
        }
    }
    private void Swipe()
    {
        Vector2 delta = Input.GetTouch(0).deltaPosition;

        if (delta.y > 0)
        {
            transform.position += Vector3.up * sdeepTouch * Time.deltaTime;
        }
        if (delta.y < 0)
        {
            transform.position -= Vector3.up * sdeepTouch * Time.deltaTime;
        }
        for (int i = 0; i < lisstLessonButton.Count; i++)
        {
            if (lisstLessonButton[i].gameObject.transform.position.y >= hideUp)
            {
                lisstLessonButton[i].ShowButtonPlay();
                lisstLessonButton[i].gameObject.SetActive(false);
            }
            else
            {
                lisstLessonButton[i].gameObject.SetActive(true);
                if (lisstLessonButton[i].gameObject.transform.position.y <= hideDown)
                {
                    lisstLessonButton[i].gameObject.SetActive(false);
                }
                else
                {
                    lisstLessonButton[i].gameObject.SetActive(true);
                }
            }
            if (transform.position.y <= stopMoveDown)
            {
                transform.position += Vector3.up * sdeepTouch * Time.deltaTime;
                //transform.position = new Vector3 (transform.position.x , stopMoveDown + 0.1f , transform.position.z);  
            }
        }
        //for (int i = 0; i < lisstLessonButton.Count; i++)
        //{

        //    if (lisstLessonButton[i].gameObject.transform.position.y <= hideDown)
        //    {
        //        lisstLessonButton[i].gameObject.SetActive(false);
        //    }
        //    else
        //    {
        //        lisstLessonButton[i].gameObject.SetActive(true);
        //    }
        //}

    }
}
