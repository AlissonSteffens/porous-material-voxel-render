using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject fluidParticle;
    private float secs;
    // Start is called before the first frame update
    void Start()
    {
        secs = 0;
    }

    // Update is called once per frame
    void Update()
    {
        secs += Time.deltaTime;
        
            Instantiate(fluidParticle, transform.position, Quaternion.identity);
         
    }
}
