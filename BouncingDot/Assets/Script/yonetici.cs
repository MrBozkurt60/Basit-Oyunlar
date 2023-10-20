using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yonetici : MonoBehaviour
{
    public GameObject altigen, top, baslangicYazisi;
    public Transform baslang�cPozisyon;
    private bool basla = false;

    void Start()
    {
        altigen.GetComponent<donus>().enabled = false;   //oyun ba�larken d�nmeyi durdur (tap to start yap�nca d�necek)
    }

    void Update()
    {
        if (Input.anyKeyDown && !basla)
        {
            top.transform.position = baslang�cPozisyon.position;   //ba�lang��a �s�nla

            top.GetComponent<Rigidbody2D>().velocity = Vector2.zero;   //top yukar� ��karken alttaki h�zdan etkilenmesin

            altigen.GetComponent<donus>().enabled = true;   //oyun ba�lad� yeniden d�ns�n

            basla = true;   //oyun baslas�n

            baslangicYazisi.SetActive(false);  //baslang�� yaz�s�n� kapat

            
        }
    }
}
