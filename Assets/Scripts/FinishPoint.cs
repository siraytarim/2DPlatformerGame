using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    public GameObject karakter;
    public GameObject panel;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "character" && ScoreGenerator.starpointt == 9)
        {
            karakter.SetActive(false);
            panel.SetActive(true);
            ScoreGenerator.starpointt = 0;


        }
    }
}
