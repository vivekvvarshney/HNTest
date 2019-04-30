using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEngine.UI;
using System.Linq;

public class HandleTextFile:MonoBehaviour
    {
    public Text textUI;
    public float limitX;
    public float limitY;
    public char[] values;
    //[MenuItem("Tools/Read file")]
    public void Start()
        {
        readFile();
        }
        void readFile()
        {
            string path = "Assets/Script/text.txt";
            StreamReader reader = new StreamReader(path);
            //Debug.Log(reader.ReadToEnd());
            //values=reader.ReadToEnd().Replace("\n","").ToCharArray();
            textUI.text = reader.ReadToEnd().Replace("\n","");
            Debug.Log("text : " + reader.ReadToEnd());
            Debug.Log("text without EOL: " + reader.ReadToEnd().Replace("\n", ""));
            //generateGrid(reader.ReadToEnd().Replace("\n", ""));
            reader.Close();
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
        }