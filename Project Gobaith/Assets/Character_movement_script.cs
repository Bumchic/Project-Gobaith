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
        
        Vector2 direction = new Vector2(xinput, yinput);

        body.velocity = direction * speed;



    }
}
