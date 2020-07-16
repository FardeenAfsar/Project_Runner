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
        if (transform.position.y < maxheight && Input.GetKey(KeyCode.UpArrow))
        {
            targetpos = new Vector2(transform.position.x, transform.position.y + yinc);
        }
        else if (transform.position.y > minheight && Input.GetKey(KeyCode.DownArrow))
        {
            targetpos = new Vector2(transform.position.x, transform.position.y - yinc);
        }
    }
}
