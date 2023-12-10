using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject Arrow;
    public float waitTime = 0.5f;
    public float delay = 0f;

    void Update()
    {
        delay -= Time.deltaTime;

        Vector2 mouseScreenPos = Input.mousePosition;
        Vector2 mouseScenePos = Camera.main.ScreenToWorldPoint(mouseScreenPos);
        Vector2 crossbowPos = transform.position;
        Vector2 wantedDirection = mouseScenePos - crossbowPos;
        Vector2 defaultDirection = Vector2.up;

        float angle = Vector2.SignedAngle(defaultDirection, wantedDirection);
        Vector3 newEuler = new Vector3(0, 0, angle);
        transform.localEulerAngles = newEuler;
        if (Input.GetMouseButtonDown(0))
        {
            if (delay <= 0f)
            {
                Instantiate(Arrow, transform.position, transform.rotation);
                delay = waitTime;
            }
        }


    }
}
