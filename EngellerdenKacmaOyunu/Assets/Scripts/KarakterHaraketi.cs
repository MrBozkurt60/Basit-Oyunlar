using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterHaraketi : MonoBehaviour
{
    public float yatayHiz;


    void Update()
    {
        float Hiz = yatayHiz * Input.GetAxis("Horizontal");

        transform.Translate(Hiz * Time.deltaTime , 0 , 0);
    }
}
