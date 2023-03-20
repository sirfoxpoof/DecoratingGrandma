using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyPath : MonoBehaviour
{
    public Transform enemy;
    public bool alerted = false;
    public Transform [] waypoints;
    public int waypoint;
    // Start is called before the first frame update
    void Start()
    {
        waypoint = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(enemy.transform.position, waypoints[waypoint].transform.position);
        if (distance < 3f)
        {
            if (waypoint == waypoints.Length)
            {
                waypoint = 0;
            }

            else
            {
                waypoint++;
            }
        }
        else
        {
            
        }
        
    }
}
