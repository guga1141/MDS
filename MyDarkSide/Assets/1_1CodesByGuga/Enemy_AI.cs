using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_AI : MonoBehaviour
{     
    public NavMeshAgent agent;

    public Transform Player;

    public LayerMask whatIsGround, whatIsPlayer;

    //Patrol
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    // Attacking
    public float timeBetweenAttacks;
    bool alreadyAttack;

    //States
    public float sightRange, attackRange;
    public bool playerInsightRange, playerInAttackRange;

    private void Awake()
    {
    Player = GameObject.Find("Player").transform;
    agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
    playerInsightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
    playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);
    if(!playerInsightRange && !playerInAttackRange) Patrolling();
    if(playerInsightRange && !playerInAttackRange) ChasePlayer();
    if(playerInsightRange && playerInAttackRange) AttackPlayer();
    }
  
    private void Patrolling()
    {    
    if (!walkPointSet) SearchWalkPoint();

    if(walkPointSet)
       agent.SetDestination(walkPoint);

       Vector3 distanceToWalkPoint = transform.position - walkPoint;

       //Walkpoint reached
       if(distanceToWalkPoint.magnitude < 1f)
       walkPointSet = false;
    }
    
    private void SearchWalkPoint()
    {
     //Calculate randon point in range
    float randomZ = Random.Range(-walkPointRange, walkPointRange);
    float randomX = Random.Range(-walkPointRange, walkPointRange);

    walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

    if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround))
    walkPointSet = true;
    }

    private void ChasePlayer()
    {
    agent.SetDestination(Player.position);        
    }

    private void AttackPlayer()
    {
    //Make sure enemy doesn't move
    agent.SetDestination(transform.position);
    transform.LookAt(Player);
    if(!alreadyAttack)
    {
     //colocar codigo de ataque aqui(se quiser)



     alreadyAttack = true;
     Invoke(nameof(ResetAttack), timeBetweenAttacks);
    }
    }
    private void ResetAttack()
    {
    alreadyAttack = false;
    }
   
   private void OnDrawGizmosSelected()
   {
    Gizmos.color = Color.blue;
    Gizmos.DrawWireSphere(transform.position, sightRange);
   }



}

