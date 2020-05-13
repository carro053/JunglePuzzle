using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L3B5 : MonoBehaviour
{
    public bool ison;
    public GameObject obj;
    public Vector3 direction;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        ison = false;
        direction = new Vector3(1, 0, 0);
        speed = 2.0f;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (ison)
        {
            obj.transform.position = new Vector3(48, 8, 0);
        }
    }
}
