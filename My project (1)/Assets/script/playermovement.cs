using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{   public float speed;
    public KeyCode upkey;
    private Vector2 dir;
    private Vector2 velocity;
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
        velocity =  speed * dir;
    }






}



