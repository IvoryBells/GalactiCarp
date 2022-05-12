using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winCondition : MonoBehaviour
{

    public int bugsDead = 0;


    // Update is called once per frame
    void Update()
    {     
        if(bugsDead == 59)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Win_Screen");
        }
    }
}
