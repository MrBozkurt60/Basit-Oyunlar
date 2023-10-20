using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Can : MonoBehaviour
{
    public static int KalanCan = 3;

    public TextMeshProUGUI CanYazýsý ;

    public GameObject BitisPaneli;
    
    void Update()
    {
        CanYazýsý.text = "Can : " + KalanCan.ToString();
        

        if(KalanCan == 0)
        {
            Time.timeScale = 0;

            BitisPaneli.SetActive(true);
        }
    }
}
