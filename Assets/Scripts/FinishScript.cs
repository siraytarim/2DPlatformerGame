using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishScript : MonoBehaviour
{
    public GameObject panel;
    public GameObject karakter;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "character" && ScoreGenerator.starpointt==10)
        {
            panel.SetActive(true);
            karakter.SetActive(false);
            ScoreGenerator.starpointt = 0;  
        }
    }
}
