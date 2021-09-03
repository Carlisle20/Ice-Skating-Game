using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour {
    public Rigidbody2D TrashBody;
    public float MinSpeed;
    public float MaxSpeed;
    
    

	// Use this for initialization
	void Start () {
        TrashBody.AddForce(transform.right * Random.Range(MinSpeed, MaxSpeed));
    }

    // Update is called once per frame
    void Update()
    {

        

        
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.name == "Player")
        {
            GameObject.Find("HealthBar").SendMessage("LoseLife");
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }
}
