using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitPos : MonoBehaviour
{
    Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition=transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0.25f){
            transform.position = new Vector3(-0.2075339f,0.7334679f,1.685021f);            
        }
            
    }
}
