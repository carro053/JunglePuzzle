using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Camera : MonoBehaviour
{

    public Transform player;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Level1")
        {
            offset = new Vector3(-2, 0, -10);
        }
        else if (SceneManager.GetActiveScene().name == "Level2")
        {
            offset = new Vector3(-2, -3, -10);
        }
        else if (SceneManager.GetActiveScene().name == "Level3")
        {
            offset = new Vector3(-2, 0, -10);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z);
    }
}
