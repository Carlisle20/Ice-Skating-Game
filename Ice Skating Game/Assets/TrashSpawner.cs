using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawner : MonoBehaviour {

    private float LastTrash;
    public GameObject Trash;
    public float UpperBound;
    public float LowerBound;
    private float Interval;
    public float XValue;
    public float MinInterval;
    public float MaxInterval;
    public float MinRoseInterval;
    public float MaxRoseInterval;
    private float RInterval;
    private float LastRose;
    public GameObject Rose;
    public GameObject Trash2;
    public float MaxTrash2Interval;
    public float MinTrash2Interval;
    private float Trash2I;
    private float LastTrash2;
    public float MaxCoinInterval;
    public float MinCoinInterval;
    private float CoinI;
    private float LastCoin;
    public GameObject Coin;
	
	// Update is called once per frame
	void Update () {

        Interval = Random.Range(MinInterval, MaxInterval);
        RInterval = Random.Range(MinRoseInterval, MaxRoseInterval);
        Trash2I = Random.Range(MinTrash2Interval, MaxTrash2Interval);
        CoinI = Random.Range(MinCoinInterval, MaxCoinInterval);


        if (Time.time - Interval >= LastTrash)
        {
            transform.position = new Vector2(XValue, Random.Range(LowerBound, UpperBound));
            Instantiate(Trash, transform.position, Quaternion.identity);
            LastTrash = Time.time;
        }

        if (Time.time - RInterval >=  LastRose)
        {
            Instantiate(Rose, transform.position, Quaternion.identity);
            LastRose = Time.time;
        }

        if (Time.time - Trash2I >= LastTrash2)
        {
            Instantiate(Trash2, transform.position, Quaternion.identity);
            LastTrash2 = Time.time;
        }

        if (Time.time - CoinI >= LastCoin)
        {
            Instantiate(Coin, transform.position, Quaternion.identity);
            LastCoin = Time.time;
        }
    }
}
