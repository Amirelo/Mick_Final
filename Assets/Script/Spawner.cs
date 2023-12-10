using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Enemy;
    public float waitTime = 0.5f;
    public float delay = 0f;

    void Update()
    {
        delay -= Time.deltaTime;
            if (delay <= 0f)
            {
                float randY = Random.Range(-0.7f, 0.5f);
                Vector3 pos = new Vector3(transform.position.x, randY, 0);
                

                Instantiate(Enemy, pos, transform.rotation);
                delay = waitTime;
            }


    }
}
