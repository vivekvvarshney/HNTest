using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCube : MonoBehaviour
{
    // Start is called before the first frame update
    //public Material White;
    //public Material Black;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision coll)
        {
        this.GetComponent<Renderer>().material = coll.gameObject.GetComponent<Material>();
        Debug.Log("Collision with: " + this.gameObject.name);
        }
}
