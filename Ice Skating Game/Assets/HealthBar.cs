using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;
    public int Lives;
    private Image Heart1Renderer;
    private Image Heart2Renderer;
    private Image Heart3Renderer;
    

	// Use this for initialization
	void Start () {
        Heart1Renderer = Heart1.GetComponent<Image>();
        Heart2Renderer = Heart2.GetComponent<Image>();
        Heart3Renderer = Heart3.GetComponent<Image>();
        
        if (Lives == 3)
        {
            Heart1Renderer.enabled = true;
            Heart2Renderer.enabled = true;
            Heart3Renderer.enabled = true;
        }
    }
	
	// Update is called once per frame
	void Update () {


        if (Lives == 2)
        {
            Heart3Renderer.enabled = false;
        }
        if (Lives == 1)
        {
            Heart2Renderer.enabled = false;
        }
        
		if (Lives <= 0)
        {
            GameObject.Find("GameController").SendMessage("EndGame");
            Heart1Renderer.enabled = false;
        }
	}

    public void LoseLife()
    {
        Lives--;
    }


    public void HealPlayer()
    {
        Lives = 3;
        Heart1Renderer.enabled = true;
        Heart2Renderer.enabled = true;
        Heart3Renderer.enabled = true;
    }
}
