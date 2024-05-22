using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreGenerator : MonoBehaviour
{
    public Text starpoint;
    public static int starpointt=0;

    private void Update()
    {
        starpoint.text = starpointt.ToString();
    
    }

}
