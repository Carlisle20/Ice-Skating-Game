using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour {

    public float Speed;
    private Vector2 StartPos;
    public bool ScrollActive;
    

	// Use this for initialization
	void Start () {
        StartPos = transform.position;
        ScrollActive = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (ScrollActive == true)
        {
            float ChangePosition = Mathf.Repeat(Time.time * Speed, 20);
            transform.position = StartPos + Vector2.right * ChangePosition;
        }
	}
}
