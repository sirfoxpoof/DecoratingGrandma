using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcHP : MonoBehaviour
{
    public int damage, health;
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        // als health minder dan 100 is word het object waar dit script op staat verwijdert
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    //zecht dat asl er twee colliders met elkaar botsen dat er dam health af gaat
    private void OnCollisionStay(Collision collision)
    {
        collision.gameObject.GetComponent<PlayerData>().healthAmount -= damage;
    }
}
