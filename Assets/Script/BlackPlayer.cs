using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlackPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject WhitePlayer;
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
        if(Input.GetKeyDown(KeyCode.W) && canMoveUp())
            {
            if((this.gameObject.transform.position + new Vector3(0f, 2f, 0f))!=WhitePlayer.transform.position)//player does not go overeach other
            this.transform.Translate(0f, 2f, 0f);
            }

        if(Input.GetKeyDown(KeyCode.S) && canMoveDown())
            {
            if((this.gameObject.transform.position + new Vector3(0f, -2f, 0f))!=WhitePlayer.transform.position)
            this.transform.Translate(0f, -2f, 0f);
            }

        if(Input.GetKeyDown(KeyCode.D) && canMoveRight())
            {
            if((this.gameObject.transform.position + new Vector3(2f, 0f, 0f))!=WhitePlayer.transform.position)
            this.transform.Translate(2f, 0f, 0f);}

        if(Input.GetKeyDown(KeyCode.A) && canMoveLeft())
            {
            if((this.gameObject.transform.position + new Vector3(-2f, 0f, 0f))!=WhitePlayer.transform.position)
            this.transform.Translate(-2f, 0f, 0f);
            }
        }
    void OnCollisionEnter(Collision col)
        {
        if(col.gameObject.GetComponent<Material>().color == Color.black)
            {
            canMoveToNext = false;
            }
        }
    bool canMoveLeft()
        {
        RaycastHit hit;
        Ray playerToCube = new Ray(this.transform.position, new Vector3(-2f, 0f, 0f));
        if(Physics.Raycast(playerToCube, out hit))
            {
            if(hit.transform.gameObject.GetComponent<Renderer>().material.color == Color.white)
            return true;
            }
        return false;
        }
    bool canMoveRight()
        {
        RaycastHit hit;
        Ray playerToCube = new Ray(this.transform.position, new Vector3(2f, 0f, 0f));
        if(Physics.Raycast(playerToCube, out hit))
            {
            if(hit.transform.gameObject.GetComponent<Renderer>().material.color == Color.white)
                return true;
            }
        return false;
        }
    bool canMoveUp()
        {
        RaycastHit hit;
        Ray playerToCube = new Ray(this.transform.position, new Vector3(0f, 2f, 0f));
        if(Physics.Raycast(playerToCube, out hit))
            {
            if(hit.transform.gameObject.GetComponent<Renderer>().material.color == Color.white)
                return true;
            }
        return false;
        }
    bool canMoveDown()
        {
        RaycastHit hit;
        Ray playerToCube = new Ray(this.transform.position, new Vector3(0f, -2f, 0f));
        if(Physics.Raycast(playerToCube, out hit))
            {
            if(hit.transform.gameObject.GetComponent<Renderer>().material.color == Color.white)
                return true;
            }
        return false;
        }
   
    

}
