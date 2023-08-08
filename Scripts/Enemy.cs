using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private StateMachineBehaviour stateMachine;
    private NavMeshAgent agent;
    public NavMeshAgent Agent { get => agent; }
    private string currentState;
    private GameObject player;
    public float sightDistance = 20f;
    public float fieldOfView = 85f;
    // Start is called before the first frame update
    void Start()
    {
        stateMachine = GetComponent<StateMachineBehaviour>();
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        CanSeePlayer();
    }

    public bool CanSeePlayer()
    {
        if (player != null)
        {
            //check to see if the player is close enough to be seen by the enemy
            if (Vector3.Distance(transform.position, player.transform.position) < sightDistance)
            {
                Vector3 targetDirection = player.transform.position - transform.position;
                float angleToPlayer = Vector3.Angle(targetDirection, transform.forward);
                if (angleToPlayer >= -fieldOfView && angleToPlayer <= fieldOfView)
                {
                    Ray ray = new Ray(transform.position, targetDirection);
                    Debug.DrawRay(ray.origin, ray.direction * sightDistance);
                }
            }
        }
        return true;
    }
}
