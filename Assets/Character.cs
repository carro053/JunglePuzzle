using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed;
    public float jumpHeight;
    private Vector3 direction;
    private Rigidbody rb;
    public LayerMask ground;
    public Transform feet;
    private int db = 0;


     // Start is called before the first frame update
    void Start()
    {
        speed = 3.0f;
        jumpHeight = 6.5f;
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
      
        direction = Vector3.zero;
        direction.x = Input.GetAxis("Horizontal");
        direction = direction.normalized;
        if (direction != Vector3.zero)
        {
            transform.forward = direction;
            rb.MovePosition(transform.position + (direction * speed * Time.deltaTime));
        }
        bool grounded()
        {
            if (Physics.CheckSphere(feet.position, .1f, ground))
            {
                db = 0;
                return true;
            }
            else { return false; }
        }
        if(Input.GetButtonDown("Jump")&& (grounded() || db < 1))
        {
            db += 1;
            rb.AddForce(Vector3.up * jumpHeight, ForceMode.VelocityChange);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Enemy" || collision.gameObject.name == "Spike (9)")
        {
            transform.position = new Vector3(-15.49f, -3.56f, 0f);
        }
    }
}
