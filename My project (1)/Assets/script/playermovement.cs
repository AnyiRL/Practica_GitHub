using System.Collections;//hola
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{   public float speed;
    public KeyCode upkey;
    private Vector2 dir;
    private float velocity;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        dir =  Vector2.zero;
        if (Input.GetKey(upkey) )
        {
            dir = new Vector2(0, 1);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity =  speed * dir;
    }






}



