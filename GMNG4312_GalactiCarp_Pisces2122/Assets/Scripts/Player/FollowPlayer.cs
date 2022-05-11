using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Transform followTarget;
    public Cinemachine.CinemachineFreeLook vcam;


    // Start is called before the first frame update
    void Start()
    {
         vcam = GetComponent<Cinemachine.CinemachineFreeLook>();

        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
            if (player != null)
            {
                followTarget = player.transform;
                vcam.LookAt = player.transform;
                vcam.Follow = player.transform;
            }
        }
    }

    private void Update()
    {
        vcam = GetComponent<Cinemachine.CinemachineFreeLook>();

        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
            if (player != null)
            {
                followTarget = player.transform;
                vcam.LookAt = player.transform;
                vcam.Follow = player.transform;
            }
        }
    }


}
