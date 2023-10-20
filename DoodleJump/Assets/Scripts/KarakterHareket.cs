using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class KarakterHareket : MonoBehaviour
{
    public float hiz;
    public Rigidbody2D doodle;
    private float hareketInput;

    public TextMeshProUGUI SkorYazisi;
    int skor;


    void Update()
    {
        SkorYazisi.text = "SKOR : " + skor;

        hareketInput = Input.GetAxis("Horizontal");

        doodle.velocity = new Vector2(hiz * hareketInput , doodle.velocity.y);   //yatay h�z� tan�mlama
    }

     void OnCollisionEnter2D(Collision2D temas)   //bitis game objesiyle temas etmesi durumu
    {
        if(temas.gameObject.tag == "biti�")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);   //ge�erli sahneyi yeniden ba�lat
        }

        if (temas.gameObject.tag == "platform")
        {
            skor += Random.Range(5 , 11);
        }
    }
}
