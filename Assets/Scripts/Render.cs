using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Render : MonoBehaviour
{
    int[,,] arrays;
    public GameObject objeto;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("carregando");
        int size = 100;
        string arquivo = FileManager.ReadFile("poros");
        Debug.Log(arquivo);
        arrays = new int[100,100,100];
        char[] chars = arquivo.ToCharArray();
        int count = 0;
        Debug.Log("gerando");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                for (int z = 0; z < size; z++)
                {
                    arrays[i,j,z] = int.Parse(chars[count].ToString());
                    if(arrays[i, j, z] == 1)
                    {
                        Instantiate(objeto, new Vector3(i, j, z), Quaternion.identity);
                    }
                    count++;
                }
            }
        }
        Debug.Log("gerado");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
