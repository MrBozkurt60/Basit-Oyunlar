using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraTakip : MonoBehaviour
{
    public Transform hedef;
    void Update()
    {
        if(hedef.position.y > transform.position.y)   //karakter y�ksekli�i kamera y�ksekli�inden fazla ise
        {
            transform.position = new Vector3(transform.position.x, hedef.position.y, transform.position.z);
        }
    } 
}
