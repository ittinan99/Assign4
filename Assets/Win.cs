using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject goalGameObject;
    public GameObject bullet;
    public Rigidbody EmptyForHandleSpringJoint;
    public SpringJoint SpringJoint;
    private void OnCollisionEnter(Collision other) 
    {
        {
               if(other.gameObject.Equals(goalGameObject))
            {
                Debug.Log("WIN");
            }
            if(other.gameObject.Equals(bullet))
            {
                SpringJoint.connectedBody = EmptyForHandleSpringJoint;
            }
        }
        
}
}
