﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCube : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject White;
    public GameObject Black;
    Renderer rend;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if(this.transform.position == White.transform.position)
        {
        Debug.Log("white on black cube");
        this.gameObject.GetComponent<Renderer>().material.color = Color.white;
        }
    if(this.transform.position == Black.transform.position)
        {
        Debug.Log("black on white cube");
        this.gameObject.GetComponent<Renderer>().material.color = Color.black;
        }
    }
    //void OnCollisionEnter(Collision coll)
    //    {
    //    //this.GetComponent<Renderer>().material = coll.gameObject.GetComponent<Renderer>().material;
    //    Debug.Log("Collision with: " + this.gameObject.name);

    //    rend = this.gameObject.GetComponent<Renderer>();
    //    if(coll.gameObject == White && this.gameObject.GetComponent<Renderer>().material.color==Color.black)
    //        {
    //            rend.material.color = Color.white;
    //        }
    //    if(coll.gameObject == Black && this.gameObject.GetComponent<Renderer>().material.color == Color.white)
    //        {
    //            rend.material.color = Color.black;
    //        }
    //    }
    
}
