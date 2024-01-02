using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickAndScore : MonoBehaviour
{
    [SerializeField] ScoreInput Score;
    public void OnMouseDown()
    {
    Score.GetComponent<ScoreInput>().score++;
    }
}

