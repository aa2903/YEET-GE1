using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SledgeTrigger : MonoBehaviour
{

    public SledgeMoving MovingPlatform;


    private void OnTriggerEnter(Collider other)
    {
        MovingPlatform.NextPlatform();
    }
}
