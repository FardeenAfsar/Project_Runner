using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    private Vector2 targetpos;
    public float yinc, speed, minheight, maxheight;
    public int health = 3;
    public float pos_x, pos_y;
    void Start()
    {
        targetpos = new Vector2(pos_x,pos_y);    
    }
    void Update()
    {
        if(health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        transform.position = Vector2.MoveTowards(transform.position, targetpos, speed * Time.deltaTime);
        if (transform.position.y < maxheight && Input.GetKeyDown(KeyCode.UpArrow))
        {
            targetpos = new Vector2(transform.position.x, transform.position.y + yinc);
        }
        else if (transform.position.y > minheight && Input.GetKeyDown(KeyCode.DownArrow))
        {
            targetpos = new Vector2(transform.position.x, transform.position.y - yinc);
        }
    }
}
