using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoseRight : MonoBehaviour {

    // Use this for initialization

    public Rigidbody2D RoseBody;
    public float MinSpeed;
    public float MaxSpeed;



    // Use this for initialization
    void Start()
    {
        RoseBody.AddForce(-transform.right * Random.Range(MinSpeed, MaxSpeed));
    }

    // Update is called once per frame
    void Update()
    {





    }

    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.name == "Player")
        {
            GameObject.Find("HealthBar").SendMessage("HealPlayer");
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }
}
