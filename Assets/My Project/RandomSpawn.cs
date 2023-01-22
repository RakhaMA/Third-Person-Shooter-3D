using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject TargetPrefab;
    public GameObject[] spawnSpots;


    // Start is called before the first frame update
    void Start()
    {
        StartInstantiate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // RandomSpawn()
    // {
    //     spawnSpots[]
    // }

    public void StartInstantiate()
    {
        Vector3 newSpot =  spawnSpots[Random.Range(0, spawnSpots.Length)].transform.position;

        GameObject temp = GameObject.Instantiate(TargetPrefab, newSpot, TargetPrefab.transform.rotation);
    }
}
