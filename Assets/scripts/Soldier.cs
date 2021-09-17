using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class Soldier : MonoBehaviour
{
    public GameObject Tower;
    public Rigidbody soldier;
    public static int Puan = 0;
    //public Text TowerHealth;
    public static int TowerHealth = 20;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<NavMeshAgent>().destination = Tower.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        //soldier.velocity = Vector3.forward * Time.deltaTime * 300f;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            Destroy(this.gameObject,0.1f);
            //EnemySoldierS.SoldierNumber--;
        }
        if (collision.gameObject.tag.Equals("Tower"))
        {
            Destroy(this.gameObject,0.1f);
            TowerHealth--;
            Debug.Log(TowerHealth + "-1");
            
        }
    }
    


}
