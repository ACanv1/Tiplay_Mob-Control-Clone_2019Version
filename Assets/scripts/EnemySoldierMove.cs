using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySoldierMove : MonoBehaviour
{
    public GameObject EnemySoldier;
    public Rigidbody EnemyRigi;
    
    
    

    // Start is called before the first frame update
    void Start()
    {
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        EnemyRigi.velocity = Vector3.back * Time.deltaTime * 300f;
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag.Equals("Players"))
        {
            
            
            
            
            Destroy(this.gameObject,0.2f); //EnemySoldier is Destroyed.
            EnemySoldierS.SoldierNumber--;
            Debug.Log(EnemySoldierS.SoldierNumber + "YOK EDÝLDÝ");
            Soldier.Puan += 5;

            Debug.Log(Soldier.Puan + "Puan Kazandýn");
            // The destroy effect will creat when the enemy Soldiers Die. "DONT FORGET!!!!"

        }
    }
}
