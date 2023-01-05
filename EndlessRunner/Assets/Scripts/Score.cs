using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
  public float scoreBoard = 0;
public TextMeshProUGUI scoreText;


    // Update is called once per frame
    void Update()
    {
       scoreText.text=(scoreBoard/6).ToString("0");
    }
}
