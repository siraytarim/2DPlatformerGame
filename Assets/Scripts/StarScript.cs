using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "character" || collision.gameObject.tag == "griküp")
        {
            ScoreGenerator.starpointt += 1;
            Destroy(this.gameObject);
        }
    }


}
