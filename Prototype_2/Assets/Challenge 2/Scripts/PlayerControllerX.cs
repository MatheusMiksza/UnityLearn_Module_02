using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float timeSpawn;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.realtimeSinceStartup >= timeSpawn+1)
        {
            timeSpawn = Time.realtimeSinceStartup;
           
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
       
    }
}
