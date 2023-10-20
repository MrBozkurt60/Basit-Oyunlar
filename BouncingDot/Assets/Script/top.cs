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
        toprb = GetComponent<Rigidbody2D>();        //toprb yi topun rigidbodysi olarak e�itle

        topRenderer = GetComponent<SpriteRenderer>();       //rendereri topun rendereri olarak e�itle

        


        if (PlayerPrefs.HasKey("rekor"))    //rekor diye bir veri var m� , ilk defa oynayanlarda hata vermesin diye
        {
            rekor = PlayerPrefs.GetInt("rekor");     //kay�tl� rekoru en ba�ta �a��r�r
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
            toprb.AddForce(Vector2.up * ziplamaGucu/2 , ForceMode2D.Impulse);   //tek seferli kuvvet i�in forcemode.impulse
        }


        if (temas.gameObject.tag == "kenar")
        {
            toprb.AddForce(Vector2.up * ziplamaGucu , ForceMode2D.Impulse);   //tek seferli kuvvet i�in forcemode.impulse


            if (topRenderer.color == temas.gameObject.GetComponent<SpriteRenderer>().color)
            {
                GetComponent<AudioSource>().Play();   //ses �al
                skor += Random.Range(5, 16);
                SkorYazisi.text = "SKOR :" + skor.ToString();   //skor int oldu�u i�in stringe �evirdim

                if(skor > rekor)
                {
                    rekor = skor;   //skor rekoru ge�erse yeni skoru rekora e�itle

                    rekorYazisi.text = "REKOR : " + rekor.ToString();

                    PlayerPrefs.SetInt("rekor", rekor);    //rekor de�i�kenini local belle�e kaydetti
                }

            }else if(topRenderer.color != temas.gameObject.GetComponent<SpriteRenderer>().color)   //ayn� renk de�ilse sahneyi yeniden ba�lat
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);   

            }
        }

       
        
    }

     void OnTriggerEnter2D(Collider2D yumusaktemas)    //renk de�i�tirme collideri
    {
        if (yumusaktemas.gameObject.tag == "RenkDegistirici")
        {
            RenkDegistir();
        }
    }


    void RenkDegistir()    //renk de�i�tirme fonksiyonu
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
