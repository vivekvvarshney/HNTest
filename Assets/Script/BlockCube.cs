using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCube : MonoBehaviour
{
    // Start is called before the first frame update
    //public Material White;
    //public Material Black;
    Renderer rend;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision coll)
        {
        this.GetComponent<Renderer>().material = coll.gameObject.GetComponent<Renderer>().material;
        Debug.Log("Collision with: " + this.gameObject.name);
        }
    
}
