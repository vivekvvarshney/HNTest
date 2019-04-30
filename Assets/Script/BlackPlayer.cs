using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject WhitePlayer;
    //public GameObject BlackPlayer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    blackPlayerMovement();
    
    }
    void blackPlayerMovement()
        {
        if(Input.GetKeyDown(KeyCode.W))
            this.transform.Translate(0f, 2f, 0f);

        if(Input.GetKeyDown(KeyCode.S))
            this.transform.Translate(0f, -2f, 0f);

        if(Input.GetKeyDown(KeyCode.D))
            this.transform.Translate(2f, 0f, 0f);

        if(Input.GetKeyDown(KeyCode.A))
            this.transform.Translate(-2f, 0f, 0f);
        }
   
    

}
