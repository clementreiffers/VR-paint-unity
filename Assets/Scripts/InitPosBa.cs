using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitPosBa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -0.5f){
            transform.position = new Vector3(-0.208f,0.43f,1.5f);            
        }
    }
}
