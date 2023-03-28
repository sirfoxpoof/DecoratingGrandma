using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Damage : MonoBehaviour
{
    private NpcHP npcHp;
    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        damage = 20;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnTriggerStay(Collider collision)
    {
        print("enemy");
        npcHp = collision.gameObject.GetComponent<NpcHP>();

        if (Input.GetMouseButtonDown(0) && collision.transform.tag == "Enemy")
        {
            npcHp.health -= damage;
        } 
    }
}

