using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class top : MonoBehaviour
{
    private Rigidbody2D toprb;
    private SpriteRenderer topRenderer;
    public float ziplamaGucu;
    public Color renk1, renk2, renk3, renk4, renk5, renk6;
    public TextMeshProUGUI SkorYazisi, rekorYazisi;
    private int skor, rekor;
    public AudioSource ses;

    void Start()
    {
        toprb = GetComponent<Rigidbody2D>();        //toprb yi topun rigidbodysi olarak eþitle

        topRenderer = GetComponent<SpriteRenderer>();       //rendereri topun rendereri olarak eþitle

        


        if (PlayerPrefs.HasKey("rekor"))    //rekor diye bir veri var mý , ilk defa oynayanlarda hata vermesin diye
        {
            rekor = PlayerPrefs.GetInt("rekor");     //kayýtlý rekoru en baþta çaðýrýr
            rekorYazisi.text = "REKOR : " + rekor.ToString();

        }
        else
        {
            rekor = 0;
        }
    }
    void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "zemin")
        {
            toprb.AddForce(Vector2.up * ziplamaGucu/2 , ForceMode2D.Impulse);   //tek seferli kuvvet için forcemode.impulse
        }


        if (temas.gameObject.tag == "kenar")
        {
            toprb.AddForce(Vector2.up * ziplamaGucu , ForceMode2D.Impulse);   //tek seferli kuvvet için forcemode.impulse


            if (topRenderer.color == temas.gameObject.GetComponent<SpriteRenderer>().color)
            {
                GetComponent<AudioSource>().Play();   //ses çal
                skor += Random.Range(5, 16);
                SkorYazisi.text = "SKOR :" + skor.ToString();   //skor int olduðu için stringe çevirdim

                if(skor > rekor)
                {
                    rekor = skor;   //skor rekoru geçerse yeni skoru rekora eþitle

                    rekorYazisi.text = "REKOR : " + rekor.ToString();

                    PlayerPrefs.SetInt("rekor", rekor);    //rekor deðiþkenini local belleðe kaydetti
                }

            }else if(topRenderer.color != temas.gameObject.GetComponent<SpriteRenderer>().color)   //ayný renk deðilse sahneyi yeniden baþlat
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);   

            }
        }

       
        
    }

     void OnTriggerEnter2D(Collider2D yumusaktemas)    //renk deðiþtirme collideri
    {
        if (yumusaktemas.gameObject.tag == "RenkDegistirici")
        {
            RenkDegistir();
        }
    }


    void RenkDegistir()    //renk deðiþtirme fonksiyonu
    {
        int rastgele = Random.Range(1, 7);

        switch (rastgele)
        {
            case 1:
                topRenderer.color = renk1;
                break;
            case 2:
                topRenderer.color = renk2;
                break;
            case 3:
                topRenderer.color = renk3;
                break;
            case 4:
                topRenderer.color = renk4;
                break;
            case 5:
                topRenderer.color = renk5;
                break;
            case 6:
                topRenderer.color = renk6;
                break;


        }
    }


}
