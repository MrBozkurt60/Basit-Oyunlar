using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dondurme : MonoBehaviour
{
   public static float donusHizi = 2f;

    
    void Update()
    {
        transform.Rotate(0f, 0f, donusHizi);
    }
}
