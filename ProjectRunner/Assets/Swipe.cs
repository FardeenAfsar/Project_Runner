using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    private bool swipeDown, swipeUp;
    private Vector2 startTouch, swipeDelta;
    private bool isDrag = false; 

    private void Update()
    {
        swipeDown = swipeUp = false;
        #region Standalone
        if (Input.GetMouseButtonDown(0))
        {
            isDrag = true;
            startTouch = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0)) {
            isDrag = false;
            Reset();
        }
        #endregion

        #region Mobile Inputs
        if(Input.touches.Length > 0)
        {
            if(Input.touches[0].phase == TouchPhase.Began)
            {
                isDrag = true;
                startTouch = Input.touches[0].position;
            }
            else if (Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled)
            {
                isDrag = false;
                Reset();
            }

        }


        #endregion

        swipeDelta = Vector2.zero;
        if(isDrag)
        {
            if(Input.touches.Length > 0)
            {
                swipeDelta = Input.touches[0].position - startTouch;
            }
            else if (Input.GetMouseButton(0))
            {
                swipeDelta = (Vector2)Input.mousePosition - startTouch;
            }
        }
        if(swipeDelta.magnitude > 10)
        {
            float x = swipeDelta.x;
            float y = swipeDelta.y;
            if(Mathf.Abs(x) < Mathf.Abs(y))
            {
                if(y < 0)
                {
                    swipeDown = true;
                }
                else
                {
                    swipeUp = true;
                }
            }
            Reset();
        }
    }

    private void Reset()
    {
        startTouch = swipeDelta = Vector2.zero;
        isDrag = false;
    }
    public Vector2 SwipeDelta {get { return swipeDelta; } }
    public bool SwipeDown { get { return swipeDown; } }
    public bool SwipeUp { get { return swipeUp; } }

}
