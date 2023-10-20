using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zipla : MonoBehaviour
{
    public float ziplamaGucu;
    private Vector2 karakterHizi;
    private Rigidbody2D fizik;

    void OnCollisionEnter2D(Collision2D temas)

    {
        if (temas.relativeVelocity.y <= 0)   //ba��l h�z <= 0 ise : ama� �steeki platforma ��kabilmek bunun i�in platform effect de kullan�dk (use one way)
        {
            fizik = temas.collider.GetComponent<Rigidbody2D>();     //karakter platforma de�er de�mez rigidbodysine ula��r


            if (fizik != null)       //temas eden objede rigidbody varsa
            {
                karakterHizi = fizik.velocity;  //karakter h�z� , fizik h�z�na e�itlenir

                karakterHizi.y = ziplamaGucu;   //karakterin y hareketini , z�palam g�c�ne e�itle

                fizik.velocity = karakterHizi;
            }
        }

    } 
}
