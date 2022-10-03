using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSpawner : MonoBehaviour
{
    [SerializeField]  GameObject objectToSpawn;
    [SerializeField] private int number;
    void Start()
    {
        for (int i = 0; i < number; i++)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-44, -78), 2, Random.Range(-40, -76));
            Instantiate(objectToSpawn, randomSpawnPosition, Quaternion.identity); 
        }

    }

   
}
