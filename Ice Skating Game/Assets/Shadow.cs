using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow : MonoBehaviour {

    public GameObject Player;
    private Vector2 PlayerPosition;
    private Transform PlayerTransform;
	// Use this for initialization
	void Start ()
    {
        PlayerTransform = Player.transform;
    }	
	
	
	// Update is called once per frame
	void Update () {
        PlayerPosition = PlayerTransform.position;
        transform.position = new Vector2(PlayerPosition.x, -2.56f);
    }
}
