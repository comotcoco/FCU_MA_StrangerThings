using Susing System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript2 : MonoBehaviour
{
    private int enemyDistance = 0;
    private int enemyCount = 10;

    private string enemys = "orc";

    private string[] enemies = new string[6];


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            EnemySearch();
        }
    }

    void EnemySearch()
    {
        for (int i = 0;i < 5; i++)
        {
            enemyDistance = Random.Range(1, 10); // pick up a number between 1 and 10

            if(enemyDistance >= 8)
            {
                print("enemies are far away");
            }

            if (enemyDistance >= 4 && enemyDistance <= 7)
            {
                print("enemies are getting closer");
            }

            if (enemyDistance < 4)
            {
                print("enemies are close");
            }
        }
    }
    void EnemyRoster()
    {
        enemies[0] = "Orc";
        enemies[1] = "Dragon";
        enemies[2] = "Vampire";
        enemies[3] = "Dinosaur";
        enemies[4] = "Elf";
        enemies[5] = "T-rex";
        enemies[6] = "Fireball";
        foreach (string enemy in enemies)
        {
            print(enemy);
        }

    }



}
