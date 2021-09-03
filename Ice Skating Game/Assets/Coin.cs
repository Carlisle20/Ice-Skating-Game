using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    // Use this for initialization

    public Rigidbody2D CoinBody;
    public float MinSpeed;
    public float MaxSpeed;



    // Use this for initialization
    void Start()
    {
        CoinBody.AddForce(transform.right * Random.Range(MinSpeed, MaxSpeed));
    }

    // Update is called once per frame
    void Update()
    {





    }

    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.name == "Player")
        {
            GameObject.Find("GameController").SendMessage("AddScoreAir");
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }
}
