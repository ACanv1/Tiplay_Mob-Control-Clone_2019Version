using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemySoldierMove : MonoBehaviour
{
    
    public Transform PlayerPoint;
    
    
    

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<NavMeshAgent>().GetComponent<NavMeshAgent>().destination = new Vector3(0, 0, -9f);


    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag.Equals("Players"))
        {
            
            
            
            
            Destroy(this.gameObject,0.1f); //EnemySoldier is Destroyed.
            EnemySoldierS.SoldierNumber--;
            Stage2Tower.SoldierNumberS2--;
            //Debug.Log(EnemySoldierS.SoldierNumber + "YOK EDÝLDÝ");
            Soldier.Puan += 5;

            //Debug.Log(Soldier.Puan + "Puan Kazandýn");
            // The destroy effect will creat when the enemy Soldiers Die. "DONT FORGET!!!!"

        }
        if (collision.gameObject.tag.Equals("Destroyer"))
        {
            
            Destroy(this.gameObject,0.05f);

        }
        
    }
}
