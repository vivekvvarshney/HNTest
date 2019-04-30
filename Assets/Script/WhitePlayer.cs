using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhitePlayer : MonoBehaviour
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
    
    whitePlayerMovement();
    }
    
        
    void whitePlayerMovement()
        {
        if(Input.GetKeyDown(KeyCode.UpArrow))
            this.transform.Translate(0f, 2f, 0f);

        if(Input.GetKeyDown(KeyCode.DownArrow))
            this.transform.Translate(0f, -2f, 0f);

        if(Input.GetKeyDown(KeyCode.RightArrow))
            this.transform.Translate(2f, 0f, 0f);

        if(Input.GetKeyDown(KeyCode.LeftArrow))
            this.transform.Translate(-2f, 0f, 0f);
        }
    

}
