﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WhiteHome : MonoBehaviour
{
    public Text t1;
    public Text turnText;
    public bool curentTurn = true;
    public GameObject White;
    public bool gameEnd = false;
    // Start is called before the first frame update
    void Start()
    {
    this.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
    }

    // Update is called once per frame
    void Update()
    {
    if(this.transform.position == White.transform.position)
        {
        Debug.Log("white wins");
        t1.text = "White Wins";
        //gameEnd = true;
        }
    
    }
}
