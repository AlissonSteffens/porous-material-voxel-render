using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGetter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static byte[,,] GetWorldData(string filename)
    {
        byte[,,] arrays;
        Debug.Log("carregando");
        int size = 100;
        string arquivo = FileManager.ReadFile(filename);
        arrays = new byte[size, size, size];
        char[] chars = arquivo.ToCharArray();
        int count = 0;
        Debug.Log("gerando");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                for (int z = 0; z < size; z++)
                {
                    
                    if (int.Parse(chars[count].ToString()) == 1)
                    {
                        arrays[i, j, z] = 2;
                    }
                    else
                    {
                        arrays[i, j, z] = 0;
                    }
                    count++;
                }
            }
        }
        Debug.Log("gerado");
        return arrays;
    }
}
