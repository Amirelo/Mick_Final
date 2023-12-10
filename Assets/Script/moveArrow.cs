using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveArrow : MonoBehaviour
{
    public int damage = 10;
    public float speed = 0.2f;

    void Start()
    {
        Destroy(gameObject, 3);
    }

    private void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Enemy enemy = collision.GetComponent<Enemy>();
            enemy.takeDamage(damage);
            Destroy(gameObject);
        }

        
    }

}