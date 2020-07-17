using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemypatterns;
    private float time_spawn;
    public float spawn_time, inc_time, inc_limit = 0.8f;
    void Update()
    {
        if(time_spawn <= 0)
        {
            int rand = Random.Range(0, enemypatterns.Length);
            Instantiate(enemypatterns[rand], transform.position, Quaternion.identity);
            time_spawn = spawn_time;
            if(spawn_time > inc_limit)
            {
                spawn_time -= inc_time;
            }
        }
        else
        {
            time_spawn -= Time.deltaTime;
        }
    }
}
