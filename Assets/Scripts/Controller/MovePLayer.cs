using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePLayer : MonoBehaviour
{
    public float Speed;
    public VariableJoystick VariableJoystick;


    private Rigidbody2D _rb;
    private RotationPlayer _rp;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rp = GetComponent<RotationPlayer>();
    }
    private void FixedUpdate ()
    {

            if (VariableJoystick.Horizontal > 0)
            {

            _rp.SetRoute(true);
                Vector2 movement = new Vector2(1, 3.0f);
                _rb.AddForce(movement * Speed );

            }
            else if (VariableJoystick.Horizontal < 0)
            {

            _rp.SetRoute(false);
            Vector2 movement = new Vector2(-1, 3.0f);
                _rb.AddForce(movement * Speed );


            }
        
    
    }

   

}
