using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;   //sahneler arasý geçiþ kütüphanesi

public class YenidenOyna : MonoBehaviour
{
    public void yenidenOyna()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Can.KalanCan = 3;
        Time.timeScale = 1;
    }
}
