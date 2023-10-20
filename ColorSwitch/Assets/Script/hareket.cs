using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class hareket : MonoBehaviour
{
    public Rigidbody2D top;
    public float ziplamaGucu;
    public Color turkuazRenk, sariRenk, morRenk, pembeRenk;
    public string mevcutRenk;
    public SpriteRenderer ressam;
    public Transform degistirici;
    public TextMeshProUGUI SkorYazisi;
    public int skor;
    public Transform kontrol1, kontrol2, cember1, cember2;
    public AudioSource ziplamaSesi;

     void Start()
    {
        dondurme.donusHizi = 0.4f;
        RastgeleRenk();
    }

    void Update()
    {
        SkorYazisi.text = "SKOR : " + skor;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            top.velocity = Vector2.up * ziplamaGucu;

            ziplamaSesi.Play();
        }
    }    

    void OnTriggerEnter2D(Collider2D temas)
    {
        if(temas.tag != mevcutRenk && temas.tag != "renkdegistirici"&& temas.tag != "kontrol1" && temas.tag != "kontrol2")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  //aktif sahneyi yeniden baþlat
        }

        if(temas.tag == "renkdegistirici")
        {
            skor++;
            degistirici.position = new Vector3(degistirici.position.x, degistirici.position.y + 10f, degistirici.position.z);
            RastgeleRenk();
            dondurme.donusHizi += 0.1f;

        }

        if(temas.tag == "kontrol1")
        {
            kontrol1.position = new Vector3(kontrol1.position.x, kontrol1.position.y + 20f, kontrol1.position.z);

            cember1.position = new Vector3(cember1.position.x, cember1.position.y + 20f, cember1.position.z);
        }

        if (temas.tag == "kontrol2")
        {
            kontrol2.position = new Vector3(kontrol2.position.x, kontrol2.position.y + 20f, kontrol2.position.z);

            cember2.position = new Vector3(cember2.position.x, cember2.position.y + 20f, cember2.position.z);
        }
    }

    void RastgeleRenk()
    {
        int rastgele = Random.Range(0, 4);

        switch(rastgele)
        {
            case 0:
                mevcutRenk = "turkuaz";
                ressam.color = turkuazRenk;
                break;

            case 1:
                mevcutRenk = "sari";
                ressam.color = sariRenk;
                break;

            case 2:
                mevcutRenk = "mor";
                ressam.color = morRenk;
                break;

            case 3:
                mevcutRenk = "pembe";
                ressam.color = pembeRenk;
                break;
        }
    }
}
