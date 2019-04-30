using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject WhitePlayer;
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
        //if((GameObject.Find("Cube").GetComponent<Material>().color == Color.white))
        if(Input.GetKeyDown(KeyCode.W))
            {
            if((this.gameObject.transform.position + new Vector3(0f, 2f, 0f))!=WhitePlayer.transform.position)//player does not go overeach other
            this.transform.Translate(0f, 2f, 0f);
            }

        if(Input.GetKeyDown(KeyCode.S))
            {
            if((this.gameObject.transform.position + new Vector3(0f, -2f, 0f))!=WhitePlayer.transform.position)
            this.transform.Translate(0f, -2f, 0f);
            }

        if(Input.GetKeyDown(KeyCode.D))
            {
            if((this.gameObject.transform.position + new Vector3(2f, 0f, 0f))!=WhitePlayer.transform.position)
            this.transform.Translate(2f, 0f, 0f);}

        if(Input.GetKeyDown(KeyCode.A))
            {
            if((this.gameObject.transform.position + new Vector3(-2f, 0f, 0f))!=WhitePlayer.transform.position)
            this.transform.Translate(-2f, 0f, 0f);
            }
        }
    //void OnCollision
   
    

}
