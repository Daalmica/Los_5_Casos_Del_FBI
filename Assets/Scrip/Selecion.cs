using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selecion : MonoBehaviour
{
    public GameObject[] levels;

    int curretLevel;

    public void correctAnswer()
    {
        if (curretLevel+1 !=levels.Length)
        {
            levels[curretLevel].SetActive(false);
            curretLevel++;
            levels[curretLevel].SetActive(true);
        }
    }
}
