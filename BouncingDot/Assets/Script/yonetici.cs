using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yonetici : MonoBehaviour
{
    public GameObject altigen, top, baslangicYazisi;
    public Transform baslangýcPozisyon;
    private bool basla = false;

    void Start()
    {
        altigen.GetComponent<donus>().enabled = false;   //oyun baþlarken dönmeyi durdur (tap to start yapýnca dönecek)
    }

    void Update()
    {
        if (Input.anyKeyDown && !basla)
        {
            top.transform.position = baslangýcPozisyon.position;   //baþlangýça ýsýnla

            top.GetComponent<Rigidbody2D>().velocity = Vector2.zero;   //top yukarý çýkarken alttaki hýzdan etkilenmesin

            altigen.GetComponent<donus>().enabled = true;   //oyun baþladý yeniden dönsün

            basla = true;   //oyun baslasýn

            baslangicYazisi.SetActive(false);  //baslangýç yazýsýný kapat

            
        }
    }
}
