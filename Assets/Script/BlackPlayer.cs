using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlackPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject WhitePlayer;
    Vector3 Up = new Vector3(0f, 2f, 0f);
    Vector3 Down = new Vector3(0f, -2f, 0f);
    Vector3 Left = new Vector3(-2f, 0f, 0f);
    Vector3 Right = new Vector3(2f, 0f, 0f);
    //public GameObject BlackPlayer;
    bool canMoveToNext=true;
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
        if(Input.GetKeyDown(KeyCode.W) && canMove(Up))
            {
            if((this.gameObject.transform.position + Up)!=WhitePlayer.transform.position)//player does not go overeach other
            this.transform.Translate(Up);
            }

        if(Input.GetKeyDown(KeyCode.S) && canMove(Down))
            {
            if((this.gameObject.transform.position + Down)!=WhitePlayer.transform.position)
            this.transform.Translate(Down);
            }

        if(Input.GetKeyDown(KeyCode.D) && canMove(Right))
            {
            if((this.gameObject.transform.position + Right)!=WhitePlayer.transform.position)
            this.transform.Translate(Right);}

        if(Input.GetKeyDown(KeyCode.A) && canMove(Left))
            {
            if((this.gameObject.transform.position + Left)!=WhitePlayer.transform.position)
            this.transform.Translate(Left);
            }
        }
    
    bool canMove(Vector3 direction)
        {
        RaycastHit hit;
        Ray playerToCube = new Ray(this.transform.position, direction);
        if(Physics.Raycast(playerToCube, out hit))
            {
            if(hit.transform.gameObject.GetComponent<Renderer>().material.color == Color.white)
                return true;
            }
        return false;
        }
    //void OnCollisionEnter(Collision col)
    //    {
    //    col.gameObject.GetComponent<Renderer>().material.color = Color.black;
    //    }
   
    

}
