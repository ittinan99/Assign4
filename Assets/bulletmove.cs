using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmove : MonoBehaviour
{
    [SerializeField] float speed;
        void Update()
    {
        
        transform.Translate(-speed,0f,0f * Time.deltaTime);
        
    }
}
