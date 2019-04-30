using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhitePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject WhitePlayer;
    public GameObject BlackPlayer;
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
            {
            if((this.gameObject.transform.position + new Vector3(0f, 2f, 0f)) != BlackPlayer.transform.position)
                this.transform.Translate(0f, 2f, 0f);
            }

        if(Input.GetKeyDown(KeyCode.DownArrow))
            {
            if((this.gameObject.transform.position + new Vector3(0f, -2f, 0f)) != BlackPlayer.transform.position)
                this.transform.Translate(0f, -2f, 0f);
            }

        if(Input.GetKeyDown(KeyCode.RightArrow))
            {
            if((this.gameObject.transform.position + new Vector3(2f, 0f, 0f)) != BlackPlayer.transform.position)
                this.transform.Translate(2f, 0f, 0f);
            }

        if(Input.GetKeyDown(KeyCode.LeftArrow))
            {
            if((this.gameObject.transform.position + new Vector3(-2f, 0f, 0f)) != BlackPlayer.transform.position)
                this.transform.Translate(-2f, 0f, 0f);
            }
        }
    

}
