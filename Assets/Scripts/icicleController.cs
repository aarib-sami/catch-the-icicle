using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icicleController : MonoBehaviour
{
    [SerializeField] float timeBtwFall;
    [SerializeField] List<GameObject> Icicles;
    [SerializeField] GameObject ChosenIcicle;

    void Update()
    {
        timeBtwFall += Time.deltaTime;


        if (timeBtwFall > 1.5)
        {
            ChosenIcicle = Icicles[Random.Range(0, Icicles.Count)];
            ChosenIcicle.GetComponent<Rigidbody2D>().gravityScale = 2;
            Icicles.Remove(ChosenIcicle);
            timeBtwFall = 0f;
        }
    }
}   
    