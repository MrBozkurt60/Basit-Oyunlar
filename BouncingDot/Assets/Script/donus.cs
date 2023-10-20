using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donus : MonoBehaviour
{
    float beklemeSuresi = 0.1f;

    void Update()
    {
        StartCoroutine(AltigenDonus());
    }

    IEnumerator AltigenDonus()   //Coroutine , ekran�n sa��na m� soluna m� bas�ld� ?
    {
        Vector2 MousePos = Camera.main.ScreenToViewportPoint(new Vector2(Input.mousePosition.x, 0f));

        if (Input.GetMouseButtonDown(0) && MousePos.x > 0)      //ekran�n sa��
        {
            transform.Rotate(0 , 0 , -30);
            yield return new WaitForSeconds(beklemeSuresi);
            transform.Rotate(0, 0, -30);

        }
        else if(Input.GetMouseButtonDown(0) && MousePos.x < 0)      //ekran�n solu
        {
            transform.Rotate(0, 0, 30);
            yield return new WaitForSeconds(beklemeSuresi);
            transform.Rotate(0, 0, 30);
        }

    }
}
