using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class NavMesh : MonoBehaviour
{
    public bool chasePlayer, alerted;
    public GameObject Player;
    public float chasePlayerDistance, speed;
    public Transform enemy;
    public Transform[] waypoints;
    public int waypoint;
    public float isInRange;
    // Start is called before the first frame update
    public void Start()
    {
        chasePlayer = true;

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.DrawRay(transform.position, transform.forward * 1, Color.Yellow);


        if (Vector3.Distance(Player.transform.position, transform.position) < chasePlayerDistance)
        {
                GetComponent<NavMeshAgent>().SetDestination(Player.transform.position);
        }
        else
        {
            float distance = Vector3.Distance(enemy.transform.position, waypoints[waypoint].transform.position);
            if (distance < 5)
            {
                if (waypoint == waypoints.Length -1 )
                {
                    waypoint = 0;
                }

                else
                {
                    waypoint++;
                }
            }

            NavMeshAgent agent = GetComponent<NavMeshAgent>();
            agent.destination = waypoints[waypoint].position;


        }
    }


}

 