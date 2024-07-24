using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Circlecontroller : MonoBehaviour
{
    float speed = 200f;
    float jumpSpeed = 400f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Is player pressing D key
        if (Input.GetKey(KeyCode.D))
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.AddForce(Vector2.right * 20f * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.AddForce(Vector2.left * 20f * Time.deltaTime);
        }
        else
        {
           
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.AddForce(Vector2.up * 600f);
        }
    }
    


}
