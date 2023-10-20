using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sise : MonoBehaviour
{
    public Transform sise;

    public TextMeshProUGUI CanYazisi , BitisYazisi ;

    public int can;

    public AudioSource siseDusurme;

    private void Update()
    {
        CanYazisi.text = "CAN : " + can;

        if(can == 0)
        {
            BitisYazisi.text = "                       OYUN BÝTTÝ !\r\n\r\nTEKRAR OYNAMAK ÝÇÝN BÝR TUÞA BASIN";

            Time.timeScale = 0;
          

            if(Input.anyKeyDown)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

                Time.timeScale = 1;
            }
        }
    }
    void OnCollisionEnter(Collision temas)
    {
        float rastgele = Random.Range(-6f, 6f);

        if (temas.gameObject.tag == "zemin")
        {
            sise.position = new Vector3(rastgele, 6f, 0f);

            can--;

            siseDusurme.Play();
        }
    }
}
