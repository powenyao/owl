using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Quickly test basic rigidbody 2d functionality.
// Use force and velocity to control the rigidbody 2d only.
// Test basic x-axis movement and jump with velocity.
// x-axis movement is applied with material 2d for friction.
public class TestPlayerController : MonoBehaviour
{
    public Rigidbody2D l_rb2d;
    public float m_speed;
    public float m_jumpForce;

    void Awake()
    {
        if(!l_rb2d)
        {
            Debug.LogError("[TestPlayerController] Rigidbody 2D is none!");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        // if move, set velocity
        // if not, reset velocity
        switch(Input.GetAxisRaw("Horizontal")) 
        {
            case 1:
                l_rb2d.velocity = new Vector2(m_speed, l_rb2d.velocity.y);
                break;
            case -1:
                l_rb2d.velocity = new Vector2(-m_speed, l_rb2d.velocity.y);
                break;
            default:
                l_rb2d.velocity = new Vector2(0.0f, l_rb2d.velocity.y);
                break;
        }

        // add force for jump
        if(Input.GetButtonDown("Jump"))
        {
            l_rb2d.AddForce(new Vector2(0.0f, m_jumpForce));
        }
    }
}
