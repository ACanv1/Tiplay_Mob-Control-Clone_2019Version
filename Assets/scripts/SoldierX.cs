using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierX : MonoBehaviour
{
    public GameObject SoldierOriginal;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerExit(Collider other) 
    {
        //Debug.Log(other.gameObject.name);
        string Carp = other.gameObject.name;
        if (Carp.Equals("Soldier(Clone)"))
        {
            CreateSoldier(0); // Called the void
            
        }
        

    }
    void CreateSoldier(int Numb) // Soldier Creater
    {
        float asd = 0;
        for (int i = 0; i < 2; i++)
        {
            asd += 0.2f;
            GameObject SoldierClone = Instantiate(SoldierOriginal, new Vector3(-2.5f + asd, 0.57f, 0f), SoldierOriginal.transform.rotation);
        }

    }

}
