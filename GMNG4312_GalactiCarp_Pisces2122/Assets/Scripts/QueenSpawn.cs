using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QueenSpawn : MonoBehaviour
{

    public GameObject player;

    public int count;
    float bossH;

    public GameObject Queen;

    // Start is called before the first frame update
    void Start()
    {
        Queen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        count = player.GetComponent<winCondition>().bugsDead;



        if (count == 58)
        {
            Queen.SetActive(true);
        }
    }

}
