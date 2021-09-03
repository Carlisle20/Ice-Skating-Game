using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public Rigidbody2D RB;
    public float JumpSpeed;
    bool CanJump = true;
    public GameObject GameController;
    public Animator Anim;
    public float PlayerSpeed;
    private bool Movement = false;
    private bool TrickAnim = false;
    private float Timer = 0;

    // Update is called once per frame
    void Update()
    {
        if (Movement == true)
        {
            Anim.Play("Running");
        } else if (Movement == false && CanJump == true && TrickAnim == false)
        {
            Anim.Play("Stationary");
        }



        if (Input.GetButtonDown("Jump") && CanJump == true)
        {
            RB.AddForce(Vector2.up * JumpSpeed);
            CanJump = false;

            Anim.Play("Jump");
        }

        // Tricks.
        if (Input.GetKeyDown(KeyCode.A) && CanJump == true)
        {
            TrickAnim = true;
            Anim.Play("Spin");
            GameObject.Find("GameController").SendMessage("AddScore");
            
        }

        if (Input.GetKeyDown(KeyCode.D) && CanJump == true)
        {
            TrickAnim = true;
            Anim.Play("Juggle");
            GameObject.Find("GameController").SendMessage("AddScore");
            
        }
        
      
        if (Input.GetKeyDown(KeyCode.W) && CanJump == false)
        {
            Anim.Play("Front Flip");
            GameObject.Find("GameController").SendMessage("AddScoreAir");
            
        }

        //Left and right movement.
        if (Input.GetKey(KeyCode.Q))
        {
            RB.AddForce(-Vector2.right * PlayerSpeed);
        }
        if (Input.GetKey(KeyCode.E))
        {
            RB.AddForce(Vector2.right * PlayerSpeed);
        }

        if (RB.velocity.x >= 1 || RB.velocity.x <= -1)
        {
            Movement = true;
        }
        else
        {
            Movement = false;
        }

        if (TrickAnim == true)
        {
            Timer = Timer + 0.01f;
            
            if (Timer >= 0.5f)
            {
                TrickAnim = false;
                Timer = 0;
            }
        }


    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (RB.velocity.y == 0)
        {
            CanJump = true;
        }
    }
}
