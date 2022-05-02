using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject spawnEnemy1, spawnEnemy2, spawnEnemyBoss;
    public GameObject hold;
    public Time timer;

    public int counter = 29; //counter for the number of enemies spawned.
    private int numHold = 29;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(multipleEnemySpawner());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator multipleEnemySpawner()
    {
        Vector3 pos = hold.transform.TransformPoint(new Vector3(0, 10, 0));
        for (int i = 0; i<numHold;i++)
        {
            
            Instantiate(spawnEnemy1, pos, Quaternion.identity);
            yield return new WaitForSeconds(1);
            counter--;

            if(i%3==0)
            {
                Instantiate(spawnEnemy2, pos, Quaternion.identity);
                yield return new WaitForSeconds(1);
                counter--;
                i++;
            }
        }

        if(counter == 0)
        {
            Instantiate(spawnEnemyBoss, pos, Quaternion.identity);
        }

    }
}
