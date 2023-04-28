using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroiOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    private float topBound = 30.0f;
    private float botBound = -15.0f;
    private GameManage gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManage").GetComponent<GameManage>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < botBound || transform.position.z > topBound || transform.position.x > topBound || transform.position.x < -topBound)
        {
            Destroy(gameObject);
        }
        
    }
}
