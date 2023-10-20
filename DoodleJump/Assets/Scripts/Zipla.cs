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
        if (temas.relativeVelocity.y <= 0)   //baðýl hýz <= 0 ise : amaç üsteeki platforma çýkabilmek bunun için platform effect de kullanýdk (use one way)
        {
            fizik = temas.collider.GetComponent<Rigidbody2D>();     //karakter platforma deðer deðmez rigidbodysine ulaþýr


            if (fizik != null)       //temas eden objede rigidbody varsa
            {
                karakterHizi = fizik.velocity;  //karakter hýzý , fizik hýzýna eþitlenir

                karakterHizi.y = ziplamaGucu;   //karakterin y hareketini , zýpalam gücüne eþitle

                fizik.velocity = karakterHizi;
            }
        }

    } 
}
