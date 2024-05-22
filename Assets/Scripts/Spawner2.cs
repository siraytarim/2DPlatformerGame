using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "griküp")
        {
            SceneManager.LoadScene(3);
            ScoreGenerator.starpointt = 0;
        }

        if (collision.gameObject.tag == "character")
        {
            SceneManager.LoadScene(3);
            ScoreGenerator.starpointt = 0;
        }
    }
}
