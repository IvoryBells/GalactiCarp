using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoteCam : MonoBehaviour
{
    public GameObject playerCam;
    public GameObject remoteCam;

    void TurnOffCam()
    {
        remoteCam.SetActive(false);
        playerCam.SetActive(true);
        
    }
}
