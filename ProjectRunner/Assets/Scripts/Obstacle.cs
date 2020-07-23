using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int damage = 1;
    public float Endpos = -18;
    private static float speed;
    
    void Update()
    {
        speed = GameObject.Find("Spawner").GetComponent<Spawner>().speed;
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x < Endpos)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Player>().health -= damage;
            Destroy(gameObject);
        }
    }
}
