using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMesh : MonoBehaviour
{
    public bool chasePlayer;
    public GameObject Player;
    public float chasePlayerDistance;
    
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
            // waypoint stuff
        }
    }

    
}

 