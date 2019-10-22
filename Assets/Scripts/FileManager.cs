using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class FileManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static string ReadFile(string path)
    {
        string output = Resources.Load<TextAsset>(path).ToString();
        return output;
    }
    public static void SavePersistence(string jsonString, string path)
    {
        path = Path.Combine(Application.persistentDataPath, path);
        using (StreamWriter streamWriter = File.CreateText(path))
        {
            streamWriter.Write(jsonString);
        }
    }

    public static string LoadPersistence(string path)
    {
        path = Path.Combine(Application.persistentDataPath, path);
        using (StreamReader streamReader = File.OpenText(path))
        {
            string jsonString = streamReader.ReadToEnd();
            return jsonString;
        }
    }
}
