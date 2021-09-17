using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier6X : MonoBehaviour
{
    public GameObject SoldierOriginals;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerExit(Collider other)
    {
        //Debug.Log(other.gameObject.name);
        string Carp = other.gameObject.name;
        if (Carp.Equals("Soldier(Clone)"))
        {
            CreateSoldier(0); // Called the Soldier Creater
            
            
        }


    }

    void CreateSoldier(int Numb) // Soldier Creater
    {
        float asd = 0;
        for (int i = 0; i < 5; i++)
        {
          asd += 0.2f;
            GameObject SoldierClones = Instantiate(SoldierOriginals, new Vector3(2.5f+asd,0.57f, 0f), SoldierOriginals.transform.rotation);
        }

    }
    
}
