using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class kasaHareket : MonoBehaviour
{
    public float yatayHiz;

    public Transform sise;

    int puan;

    public TextMeshProUGUI puanYazisi;

    public AudioSource SiseAlma;

    void Update()
    {
        puanYazisi.text = "PUAN : " + puan;

        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(-yatayHiz * Time.deltaTime, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(yatayHiz * Time.deltaTime, 0f, 0f);
        }
    }

     void OnCollisionEnter(Collision temas)
    {
        float rastgele = Random.Range(-6f, 6f);

        if(temas.gameObject.tag == "sise")
        {
            sise.position = new Vector3(rastgele, 6f, 0f);

            puan += 5;

            SiseAlma.Play();
        }
    }
}
