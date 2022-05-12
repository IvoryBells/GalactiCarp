using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winCondition : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {


        //queenbug health == 0 
        if(GetComponent<HarmEnemy>().deathCount == 30)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Win_Screen");
        }
    }
}
