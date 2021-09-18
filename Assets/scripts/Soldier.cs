using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class Soldier : MonoBehaviour
{
    public GameObject Tower;
    
    public static int Puan = 0;
    
    public static int TowerHealth = 20;

    public static int TowerHealthSt2 = 25;
    

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<NavMeshAgent>().destination = Tower.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            Destroy(this.gameObject,0.1f);
            
        }
        if (collision.gameObject.tag.Equals("Tower"))
        {
            Destroy(this.gameObject,0.1f);
            TowerHealth--;
           
            Debug.Log(TowerHealthSt2+" -1");
            //Debug.Log(TowerHealth + "-1");
        }
        if (collision.gameObject.tag.Equals("Tower2"))
        {
            Destroy(this.gameObject, 0.1f);
            TowerHealthSt2--;
        }
        if (collision.gameObject.tag.Equals("destroyer"))
        {
            Destroy(gameObject);
        }
    }
   


}
