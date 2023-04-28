using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private int score = 0;
    private Assets.Scripts.ScoreEnun.PontosAnimais PontosAnimais;
    private GameManage gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManage").GetComponent<GameManage>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"Score: {score}");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Animal") && other.CompareTag("Player"))
        {

            if (gameManager.AddLives(-1) <= 0) { Destroy(other.gameObject); Debug.Log("Game Over");}
            
        }

        else if (gameObject.CompareTag("Animal") && other.gameObject.CompareTag("Pizza"))
        {
            //gameManager.AddScore(5);
            //Destroy(gameObject);
            gameObject.GetComponent<AnimalHungre>().FeedAnimal(1);
            Destroy(other.gameObject);
        }

    }

    void SomaPontos()
    {
       
        if (gameObject.name.Contains("Animal_Fox_01"))
            score = score + (int)Assets.Scripts.ScoreEnun.PontosAnimais.Animal_Fox_01;
        else if (gameObject.name.Contains("Animal_Moose_01"))
            score = score + (int)Assets.Scripts.ScoreEnun.PontosAnimais.Animal_Moose_01;
        else if (gameObject.name.Contains("Animal_Stag_01"))
            score = score + (int)Assets.Scripts.ScoreEnun.PontosAnimais.Animal_Stag_01;
    }
}
