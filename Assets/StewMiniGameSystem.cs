using System;
using System.Collections.Generic;
using UnityEngine;

public class StewMiniGameSystem : MonoBehaviour
{
    [SerializeField]
    Transform start, end;


    [SerializeField]
    GameObject hitObjects;

    int spawnAmount = 3;
    int rounds = 2;

    List<GameObject> hitEntities = new List<GameObject>();
    void Start()
    {
        Generate();
    }

    private void Generate()
    {
        //Instantiate(hitObjects, transform.position,);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
