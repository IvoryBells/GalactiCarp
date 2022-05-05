using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    Animator animate;

    int isWalkingHash;
    int isJumpingHash;
    // Start is called before the first frame update
    void Start()
    {
        animate = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isJumpingHash = Animator.StringToHash("isJumping");
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = animate.GetBool(isWalkingHash);
        bool isJumping = animate.GetBool(isJumpingHash);
        bool forwardPress = Input.GetKey("w");
        bool jumpPress = Input.GetKey(KeyCode.Space);

        if(!isWalking && forwardPress)
        {
            animate.SetBool(isWalkingHash, true);

        }

        if (isWalking && !forwardPress)
        {
            animate.SetBool(isWalkingHash, false);

        }

        if (!isJumping && jumpPress)
        {
            animate.SetBool(isJumpingHash, true);

        }

        if (isJumping && !jumpPress)
        {
            animate.SetBool(isJumpingHash, false);

        }
    }
}
