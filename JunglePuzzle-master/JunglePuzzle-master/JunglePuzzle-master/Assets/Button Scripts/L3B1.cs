using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L3B1 : MonoBehaviour
{

    public GameObject obj;
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


            Instantiate(obj, new Vector3(3, 4, 0), Quaternion.identity);

    }
}
