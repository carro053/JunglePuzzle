using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1E1 : MonoBehaviour
{
    public float speed;
    private Vector3 direction;
    private Rigidbody controller;
    // Start is called before the first frame update
    void Start()
    {
        speed = 2.0f;
        direction=new Vector3(-1,0,0);
        controller = GetComponent<Rigidbody>();
}

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x <= -5)
            direction = new Vector3(1, 0, 0);
        else if (this.transform.position.x >= -3.5)
            direction = new Vector3(-1, 0, 0);
        controller.MovePosition(transform.position + (direction * speed * Time.deltaTime));
    }
}
