using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhitePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject WhitePlayer;
    public GameObject BlackPlayer;
    
    Vector3 Up = new Vector3(0f, 2f, 0f);    
    Vector3 Down = new Vector3(0f, -2f, 0f);    
    Vector3 Left = new Vector3(-2f, 0f, 0f);    
    Vector3 Right = new Vector3(2f, 0f, 0f);
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
        if(Input.GetKeyDown(KeyCode.UpArrow) && canMove(Up))
            {
            if((this.gameObject.transform.position + Up) != BlackPlayer.transform.position)
                this.transform.Translate(Up);
            }

        if(Input.GetKeyDown(KeyCode.DownArrow) && canMove(Down))
            {
            if((this.gameObject.transform.position + Down) != BlackPlayer.transform.position)
                this.transform.Translate(Down);
            }

        if(Input.GetKeyDown(KeyCode.RightArrow) && canMove(Right))
            {
            if((this.gameObject.transform.position + Right) != BlackPlayer.transform.position)
                this.transform.Translate(Right);
            }

        if(Input.GetKeyDown(KeyCode.LeftArrow) && canMove(Left))
            {
            if((this.gameObject.transform.position + Left) != BlackPlayer.transform.position)
                this.transform.Translate(Left);
            }
        }
    
    bool canMove(Vector3 direction)
        {
        RaycastHit hit;
        Ray playerToCube = new Ray(this.transform.position, direction);
        if(Physics.Raycast(playerToCube, out hit))
            {
            if(hit.transform.gameObject.GetComponent<Renderer>().material.color == Color.black)
                return true;
            }
        return false;
        }
    //void OnCollisionEnter(Collision col)
    //    {
    //    col.gameObject.GetComponent<Renderer>().material.color = Color.white;
    //    }
}
