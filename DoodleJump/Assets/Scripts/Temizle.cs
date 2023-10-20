using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//bu game objeyi karaktere child olarak verdim ve onunla beraber hareket edecek aþaðýdaki kodlarla deðdiði platformlarý yukarý atarak sonsuz oyun olacak

public class Temizle : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D temas)
    {
        float rastgeleX = Random.Range(-10f, 11f);

        float rastgeleY = 20f;   //bir sonraki platformu atama

        if(temas.tag == "platform")
        {
            temas.transform.position = new Vector3(rastgeleX, transform.position.y + rastgeleY , transform.position.z);
        }
    }  
}
