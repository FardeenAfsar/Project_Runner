using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector2 targetpos;
    public float yinc, speed, minheight, maxheight;
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetpos, speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < maxheight)
        {
            targetpos = new Vector2(transform.position.x, transform.position.y + yinc);
        }
        else if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > minheight)
        {
            targetpos = new Vector2(transform.position.x, transform.position.y - yinc);
        }
    }
}
