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
        if(Input.GetKeyDown(KeyCode.UpArrow) && canMoveUp())
            {
            if((this.gameObject.transform.position + new Vector3(0f, 2f, 0f)) != BlackPlayer.transform.position)
                this.transform.Translate(0f, 2f, 0f);
            }

        if(Input.GetKeyDown(KeyCode.DownArrow) && canMoveDown())
            {
            if((this.gameObject.transform.position + new Vector3(0f, -2f, 0f)) != BlackPlayer.transform.position)
                this.transform.Translate(0f, -2f, 0f);
            }

        if(Input.GetKeyDown(KeyCode.RightArrow) && canMoveRight())
            {
            if((this.gameObject.transform.position + new Vector3(2f, 0f, 0f)) != BlackPlayer.transform.position)
                this.transform.Translate(2f, 0f, 0f);
            }

        if(Input.GetKeyDown(KeyCode.LeftArrow) && canMoveLeft())
            {
            if((this.gameObject.transform.position + new Vector3(-2f, 0f, 0f)) != BlackPlayer.transform.position)
                this.transform.Translate(-2f, 0f, 0f);
            }
        }
    bool canMoveLeft()
        {
        RaycastHit hit;
        Ray playerToCube = new Ray(this.transform.position, new Vector3(-2f, 0f, 0f));
        if(Physics.Raycast(playerToCube, out hit))
            {
            if(hit.transform.gameObject.GetComponent<Renderer>().material.color == Color.black)
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
            if(hit.transform.gameObject.GetComponent<Renderer>().material.color == Color.black)
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
            if(hit.transform.gameObject.GetComponent<Renderer>().material.color == Color.black)
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
            if(hit.transform.gameObject.GetComponent<Renderer>().material.color == Color.black)
                return true;
            }
        return false;
        }

}
