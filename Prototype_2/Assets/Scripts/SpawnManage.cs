using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManage : MonoBehaviour
{
    public GameObject[] animalsPrefab;
    public int animalsIndex;
    private float spawnRangeX = 30;
    private float spawnRangeZ = 29;
    private float startDeley = 2;
    private float startInterval = 0.5f;
    private float spawnX;
    private float spawnZ;
    private Quaternion spawnRotation;
    // Start is called before the first frame update

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDeley, startInterval);
    }

    // Update is called once per frame
    void Update()
    {
              
    }

    void SpawnRandomAnimal()
    {
        spawnX = Random.Range(-spawnRangeX, spawnRangeX);
        if (spawnX > 20) spawnX = 25;
        else if (spawnX < -20) spawnX = -25;

        if (spawnX > 20 || spawnX < -20) spawnZ = Random.Range(0,20f);
        else spawnZ = spawnRangeZ;


        Vector3 spawnPos = new Vector3(spawnX, 0, spawnZ);
        animalsIndex = Random.Range(0, animalsPrefab.Length);
        SetRotation(animalsPrefab[animalsIndex]);
        Instantiate(animalsPrefab[animalsIndex],
            spawnPos,
            spawnRotation);
    }
    void SetRotation(GameObject animal)
    {
        switch (spawnX)
        {
            case 25: {
                    spawnRotation =  Quaternion.Euler(animal.transform.rotation.x,
                                                   -90f,
                                                   animal.transform.rotation.z);
                    break; }
            case-25:
                {
                    spawnRotation =  Quaternion.Euler(animal.transform.rotation.x,
                                                   -90f,
                                                   animal.transform.rotation.z);
                    break;
                }
            default:
                {
                    spawnRotation = new Quaternion(animal.transform.rotation.x,
                                                   animal.transform.rotation.y,
                                                   animal.transform.rotation.z,
                                                   animal.transform.rotation.w);
                    break;
                }
        }
        
    }
}
