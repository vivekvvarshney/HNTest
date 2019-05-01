using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEngine.UI;
using System.Linq;

public class HandleTextFile : MonoBehaviour
    {
    public Text textUI;
    public float limitX;
    public float limitY;
    public char[] values;
    public int length;
    public int number_of_rows = 5;
    public int number_of_columns = 3;
    public char[,] grid;
    public GameObject CubePrefab;
    //[MenuItem("Tools/Read file")]
    public void Start()
        {
        readFile();
        //makeGrid(grid, number_of_rows, number_of_columns,readFile());
        }
    string readFile()
        {
        string path = "Assets/Script/text.txt";
        StreamReader reader = new StreamReader(path);
        //Debug.Log(reader.ReadToEnd());
        //values=reader.ReadToEnd().Replace("\n","").ToCharArray();
        textUI.text = reader.ReadToEnd().Replace("\n", "");
        Debug.Log("text : " + reader.ReadToEnd());
        Debug.Log("text without EOL: " + reader.ReadToEnd().Replace("\n", ""));
        //generateGrid(reader.ReadToEnd().Replace("\n", ""));
        //length = reader.ReadToEnd().Replace("\n", "").Length;
        //number_of_rows = reader.ReadToEnd().ToCharArray().Count(c => c == '\n');
        //number_of_columns = reader.ReadToEnd().IndexOf('\n', 0, 1);
        reader.Close();
        return textUI.text;
        }
    void generateGrid(string s)
        {
        int length = s.Replace("\n", "").Length;
        int number_of_rows = s.ToCharArray().Count(c => c == '\n');
        int number_of_columns = s.IndexOf('\n', 0, 1);
        Debug.Log("number_of_rows : " + number_of_rows);
        Debug.Log("number_of_columns : " + number_of_columns);
        //textUI.text = ("number_of_rows: " + number_of_rows + "\n number_of_columns: " + number_of_columns);
        }


    void makeGrid(char[,] grid,int rowNum, int colNum,string text)
        {
            int count = 0;
            grid=new char[colNum,rowNum];
            for(int i = colNum - 1; i <= 0; i--)
                {
                    for(int j = rowNum - 1; j <= 0; j--)
                    {
                    if(count < text.Length)
                        {
                        grid[i, j] = text[count];
                        GameObject obj = (GameObject)Instantiate(CubePrefab, new Vector3((float)(i), (float)(j), 0f), Quaternion.identity);
                        if(text[count] == 'b')
                            {
                            obj.GetComponent<Renderer>().material.color = Color.black;
                            GameObject.Find("BlackPlayer").transform.Translate((float)(i), (float)(j), -1.35f);
                            }
                        else if((text[count] == 'w'))
                            {
                            obj.GetComponent<Renderer>().material.color = Color.black;
                            GameObject.Find("WhitePlayer").transform.Translate((float)(i), (float)(j), -1.35f);
                            }
                        else if((text[count] == '0'))
                            {
                            obj.GetComponent<Renderer>().material.color = Color.black;
                            }
                        else if((text[count] == '1'))
                            {
                            obj.GetComponent<Renderer>().material.color = Color.white;
                            }
                        else if((text[count] == 'p'))
                            {
                            //black home
                            obj.GetComponent<Renderer>().material.color = Color.grey;
                            }
                        else if((text[count] == 'k'))
                            {
                            //white home
                            obj.GetComponent<Renderer>().material.color = Color.yellow;
                            }
                        }
                    }
                }
        }
    }