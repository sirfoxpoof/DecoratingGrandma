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
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        collision.gameObject.GetComponent<PlayerData>().healthAmount -= damage;

    }
}
