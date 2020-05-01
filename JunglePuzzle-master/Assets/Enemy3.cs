using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3: MonoBehaviour
{
    public float speed;
    private Vector3 direction;
    public int counter;
    private Rigidbody controller;
    // Start is called before the first frame update
    void Start()
    {
        speed = 2.0f;
        direction = new Vector3(-1, 0, 0);
        controller = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (counter < 75)
        {
            counter++;
        }
        else
        {
            counter = 0;
            direction = direction * -1;
        }
        controller.MovePosition(transform.position + (direction * speed * Time.deltaTime));
    }
}