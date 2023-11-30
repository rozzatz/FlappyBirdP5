using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    private bool isDead = false;
    private Rigidbody2D rb2d;
    public float upforce = 200f;


    // VIDEO 4/10 2:19
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       if (isDead == false)
        {
            if (Input.GetMouseButtonDown (0))
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, upforce));
            }
        }
    }

    void OnCollisionEnter2D()
    {
        isDead = true;
    }
}
