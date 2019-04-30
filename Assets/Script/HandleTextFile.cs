using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEngine.UI;

public class HandleTextFile:MonoBehaviour
    {
    public Text textUI;
    //[MenuItem("Tools/Read file")]
    public void Update()
        {
        readFile();

        }
    void readFile()
        {
        string path = "Assets/Script/text.txt";
        StreamReader reader = new StreamReader(path);
        //Debug.Log(reader.ReadToEnd());
        textUI.text = reader.ReadToEnd();
        reader.Close();
        }

    }