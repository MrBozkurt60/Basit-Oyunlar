using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeviyeOlusturucu : MonoBehaviour
{
    public GameObject platformObjesi;
    public int platformSayisi;   //oluþturma sayýsý
    public float minX , maxX;    //koordinatýn x bileþeni
    public float minY , maxY;    //koordinatýn y bileþeni

    void Start()        //oyun baþýnda platform sayýsý kadar platform oluþturur ve seviye olur
    {
        Vector3 klonPozisyonu = new Vector3();

        for (int i = 0; i < platformSayisi; i++) //for döngüsünün kaç defa çalýþacaðýna i karar verir ve aþaðýdaki iþlemi platform sayýsý kadar gerçekleþtirir
        {
            klonPozisyonu.x = Random.Range(minX, maxX);
            klonPozisyonu.y = Random.Range(minY, maxY);

            Instantiate(platformObjesi, klonPozisyonu, Quaternion.identity);   //obje , pozisyonu , açýsý
        }

    }
}
