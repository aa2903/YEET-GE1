using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{

    public GameObject theEnemy;

    private int xPos;
    private int zPos;
    [SerializeField] private int enemyCount;

    private bool spawned = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && spawned == false )
        {
            spawned = true;
            StartCoroutine(EnemyDrop());
            StartCoroutine(Enemydrop2());
        }

        
    }


    IEnumerator Enemydrop2()
    {
        int counter = 0;
        while (counter < enemyCount)
        {
            //Spawn area on xaxis is in xcoordinates in 496 to 559
            xPos = Random.Range(496, 559);
            //spawn area on zaxis is in zcoordinates in 318 to 456
            zPos = Random.Range(318, 456);

            Instantiate(theEnemy, new Vector3(xPos, 1, zPos), Quaternion.identity);

            yield return new WaitForSeconds(0.1f);
            counter += 1;
        }
    }

    IEnumerator EnemyDrop()
    {
        int counter = 0;
        while ( counter < enemyCount)
        {
            //Spawn area on xaxis is in xcoordinates in 535 to 600
            xPos = Random.Range(535, 600);
            //spawn area on zaxis is in zcoordinates in 430 to 490
            zPos = Random.Range(430, 490);

            Instantiate(theEnemy, new Vector3(xPos, 1, zPos), Quaternion.identity);

            yield return new WaitForSeconds(0.1f);
            counter += 1;
        }
    }

}
