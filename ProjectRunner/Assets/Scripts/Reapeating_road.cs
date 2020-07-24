using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reapeating_road : MonoBehaviour
{
    public float speed, end_x, start_x, sp_inc, speed_lim;
    private float time_sp;
    void FixedUpdate()
    {
        time_sp = GameObject.Find("Spawner").GetComponent<Spawner>().time_spawn;
        if (time_sp <= 0 && speed < speed_lim)
        {
            speed += sp_inc;
        }   
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x <= end_x)
        {
            Vector2 position = new Vector2(start_x, transform.position.y);
            transform.position = position;
        }
        
    }
}
