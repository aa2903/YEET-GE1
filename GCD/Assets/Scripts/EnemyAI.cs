 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{

    //[SerializeField] Transform target;
    [SerializeField] float chaseRange = 5f;
    GameObject targetPlayer;

    NavMeshAgent navMeshAgent;
    float distanceToTarget = Mathf.Infinity;
    bool isProvoked = false;
    public float timeBetweenAttacks;
    bool alreadyAttacked;

    PlayerVariables target;
    [SerializeField] float damage = 40f;


    //Animator Controls
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {

        targetPlayer = GameObject.FindWithTag("Player");
        navMeshAgent = GetComponent<NavMeshAgent>();
        target = FindObjectOfType<PlayerVariables>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        distanceToTarget = Vector3.Distance(targetPlayer.transform.position, transform.position);
        if (isProvoked)
        {
            EngageTarget();
            
        }
        else if (distanceToTarget <= chaseRange)
        {
            isProvoked = true;
           

        }
    }


    private void EngageTarget()
    {
        if (distanceToTarget >= navMeshAgent.stoppingDistance)
        {
            ChaseTarget();
           
        }
        if (distanceToTarget <= navMeshAgent.stoppingDistance)
        {
            //NavMeshAgent.Destroy(targetPlayer);
            AttackTarget();
           
        }

       
    }

    private void ChaseTarget()
    {
        navMeshAgent.SetDestination(targetPlayer.transform.position);
        anim.SetTrigger("Chase");
    }


    private void AttackTarget()
    {
        anim.SetTrigger("Attacking");
        Debug.Log("I'm attacking! " + targetPlayer);
        if (target == null) return;
        target.TakeDamage(damage);
        Debug.Log("Bang");

        alreadyAttacked = true;
        if (!alreadyAttacked)
        {
            //attack code here

            //
            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }

    }

    private void ResetAttack()
    {

        alreadyAttacked = false;
    }




    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }
}
