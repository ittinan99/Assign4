using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    void Update() 
    {
        if(Input.GetKey(KeyCode.W))  
        {
            transform.position += new Vector3(0f, 5f ,0f) * Time.deltaTime;
        }  
        if(Input.GetKey(KeyCode.S))  
        {
            transform.position += new Vector3(0f, -5f ,0f) * Time.deltaTime;
        }  
    }
}
