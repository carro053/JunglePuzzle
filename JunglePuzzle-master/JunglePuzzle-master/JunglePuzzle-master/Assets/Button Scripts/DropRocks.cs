using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropRocks : MonoBehaviour
{
    public GameObject obj1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Player (1)")
        {
            obj1.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
