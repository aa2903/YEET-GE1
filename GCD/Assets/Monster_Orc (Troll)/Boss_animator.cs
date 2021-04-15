using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_animator : MonoBehaviour
{

    Animator Monster_orc;
    // Start is called before the first frame update
    void Start()
    {
        Monster_orc.SetTrigger("Monster_anim|Idle_1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
