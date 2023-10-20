using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeviyeOlusturucu : MonoBehaviour
{
    public GameObject platformObjesi;
    public int platformSayisi;   //olu�turma say�s�
    public float minX , maxX;    //koordinat�n x bile�eni
    public float minY , maxY;    //koordinat�n y bile�eni

    void Start()        //oyun ba��nda platform say�s� kadar platform olu�turur ve seviye olur
    {
        Vector3 klonPozisyonu = new Vector3();

        for (int i = 0; i < platformSayisi; i++) //for d�ng�s�n�n ka� defa �al��aca��na i karar verir ve a�a��daki i�lemi platform say�s� kadar ger�ekle�tirir
        {
            klonPozisyonu.x = Random.Range(minX, maxX);
            klonPozisyonu.y = Random.Range(minY, maxY);

            Instantiate(platformObjesi, klonPozisyonu, Quaternion.identity);   //obje , pozisyonu , a��s�
        }

    }
}
