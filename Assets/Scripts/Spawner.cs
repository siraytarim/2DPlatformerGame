using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour            // mash renderer,� kapat�rsak g�r�nmez
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if((collision.gameObject.tag == "character"))
        {
            SceneManager.LoadScene(2);
            ScoreGenerator.starpointt = 0;
        }
    }
}
