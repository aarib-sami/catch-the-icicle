using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreInput : MonoBehaviour
{
    [SerializeField] public float score;
    void Update()
    {
    gameObject.GetComponent<TextMeshProUGUI>().text = score.ToString(); 
    }
}
