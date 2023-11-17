using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float sdeepTouch = 2f;

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
    }
}
