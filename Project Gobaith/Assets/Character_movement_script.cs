using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_movement_script : MonoBehaviour
{
    public Rigidbody2D body;
    public float speed;
   
    void Start()
    {
        
    }

    
    void Update()
    {
        float xinput = Input.GetAxis("Horizontal");
        float yinput = Input.GetAxis("Vertical");
        
        

        if(Mathf.Abs(xinput) > 0)
        {
            body.velocity = new Vector2(xinput * speed, body.velocity.y);
        }

       if(Mathf.Abs(yinput) > 0)
        {
            body.velocity = new Vector2(body.velocity.x, yinput * speed);
        }



    }
}
