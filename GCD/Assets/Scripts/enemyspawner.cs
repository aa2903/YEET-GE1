using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{

    public GameObject theEnemy;

    public int xPos;
    public int zPos;
    public int enemyCount;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {


            StartCoroutine(EnemyDrop());
            StartCoroutine(Enemydrop2());
        }
            
     
        
    }


    IEnumerator Enemydrop2()
    {
        while (enemyCount < 10)
        {
            //Spawn area on xaxis is in xcoordinates in 496 to 559
            xPos = Random.Range(496, 559);
            //spawn area on zaxis is in zcoordinates in 318 to 456
            zPos = Random.Range(318, 456);

            Instantiate(theEnemy, new Vector3(xPos, 1, zPos), Quaternion.identity);

            yield return new WaitForSeconds(0.1f);
            enemyCount += 1;
        }
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount < 15)
        {
            //Spawn area on xaxis is in xcoordinates in 535 to 600
            xPos = Random.Range(535, 600);
            //spawn area on zaxis is in zcoordinates in 430 to 490
            zPos = Random.Range(430, 490);

            Instantiate(theEnemy, new Vector3(xPos, 1, zPos), Quaternion.identity);

            yield return new WaitForSeconds(0.1f);
            enemyCount += 1;
        }
    }

}
