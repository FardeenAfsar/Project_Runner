using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reapeating_road : MonoBehaviour
{
    public float speed, end_x, start_x;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x <= end_x)
        {
            Vector2 position = new Vector2(start_x, transform.position.y);
            transform.position = position;
        }
    }
}
