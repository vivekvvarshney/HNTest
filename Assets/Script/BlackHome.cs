using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlackHome : MonoBehaviour
{
    public Text t1;
    public GameObject Black;
    // Start is called before the first frame update
    void Start()
    {
    this.gameObject.GetComponent<Renderer>().material.color = Color.grey;
    }

    // Update is called once per frame
    void Update()
    {
    if(this.transform.position == Black.transform.position)
        {
        Debug.Log("black wins");
        t1.text = "black Wins";
        GameObject.Find("WhiteHome").GetComponent<WhiteHome>().gameEnd = true;
        }
    
    }
}
