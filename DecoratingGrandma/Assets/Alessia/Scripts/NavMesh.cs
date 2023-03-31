using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class NavMesh : MonoBehaviour
{
    public GameObject Player;
    public float chasePlayerDistance;
    public Transform enemy;
    public Transform[] waypoints;
    public int waypoint;
    // Start is called before the first frame update
    public void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.DrawRay(transform.position, transform.forward * 1, Color.Yellow);

        //Afstand player en chasePlayerDistance kleiner dan 
        if (Vector3.Distance(Player.transform.position, transform.position) < chasePlayerDistance)
        { 
                GetComponent<NavMeshAgent>().SetDestination(Player.transform.position);
        }
        else
        {
            //Pakt in de Vector3 de afstand tussen de enemy position en de waypoints positions
            float distance = Vector3.Distance(enemy.transform.position, waypoints[waypoint].transform.position);
            if (distance < 5)
            {   //Waypoint verhaal
                if (waypoint == waypoints.Length -1 )
                {
                    waypoint = 0;
                }
                else
                {
                    waypoint++;
                }
            }
            //Zet de NavMesh agent bestemming naar de waypoint positie
            NavMeshAgent agent = GetComponent<NavMeshAgent>();
            agent.destination = waypoints[waypoint].position;
        }
    }
}

 