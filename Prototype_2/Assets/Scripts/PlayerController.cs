using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizotalInput;
    private float verticalInput;
    private float speed = 10f;
    private float xRange = 20f;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
       

        horizotalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(Time.deltaTime * speed * horizotalInput, 0, Time.deltaTime * speed * verticalInput));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Lança a pizza do player apertando espaço 

            //Instantiate() cria um clone do de um PreFap
            Instantiate(projectilePrefab, new Vector3(transform.position.x, transform.position.y +1.5f,transform.position.z), projectilePrefab.transform.rotation);
        }
        
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.name.Contains("Pizza")) return;

        

    //    vidas--;
    //    if (vidas <= 0)
    //    {
    //        Destroy(gameObject);
    //        Debug.Log("Game Over!");
    //        return;

    //    }

   //}


}
