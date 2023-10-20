using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Engeller : MonoBehaviour
{
    static int skor;  //sopa ve býçaktan sadece birisiyle puan gelince static ekledik

    public TextMeshProUGUI SkorYazisi , Bitis ;

    private void Start()
    {
        skor = 0;
    }
    void Update()
    {
        SkorYazisi.text = skor.ToString();
        Bitis.text = "Oyun Bitti ! \n Skor : " + skor.ToString();
    } 

    void OnCollisionEnter2D(Collision2D temas)
    {
        float xPozisyon = Random.Range(-8f, 8f);

        float yPozisyon = Random.Range(6.5f, 15f);

        if(temas.gameObject.tag == "KontrolCubugu")
        {
            transform.position = new Vector2(xPozisyon, yPozisyon);

            skor += Random.Range(8, 13);

        }else if(temas.gameObject.tag == "karakter")
        {
            transform.position = new Vector2(xPozisyon, yPozisyon);
            Can.KalanCan--;
        }

       
    }

   
}
