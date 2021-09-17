using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySoldierS : MonoBehaviour
{
    
    public GameObject EnemySol;
    public Rigidbody EnemyRigi;
    public static int SoldierNumber;
    private float Timer;
    

    // Start is called before the first frame update
    void Start()
    {
        SoldierNumber = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Timer += Time.deltaTime;
        //Debug.Log(Timer);
        if (Timer >2 && Timer < 2.1f) // 5 soldiers created 
        {
            //Instantiate(EnemySol, new Vector3(Random.Range(-2.65f, 2.65f), 0.6f, 23f), EnemySol.transform.rotation);
            SoldierNumber++;
            //Debug.Log(SoldierNumber + " olusturuldu");

        }
        if (Timer >5 && Timer < 5.2f) // 10 soldiers created because I increase the second value number one.
        {
            //Instantiate(EnemySol, new Vector3(Random.Range(-2.65f, 2.65f), 0.6f, 23f), EnemySol.transform.rotation);
            SoldierNumber++;
            //Debug.Log(SoldierNumber + " olusturuldu");
        }
        if (Timer > 10 && Timer < 10.3) // 15 soldiers created because I increase the second value number two.
        {
            //Instantiate(EnemySol, new Vector3(Random.Range(-2.65f, 2.65f), 0.6f, 23f), EnemySol.transform.rotation);
            SoldierNumber++;
            //Debug.Log(SoldierNumber + " olusturuldu");
        }
        if (Timer > 15 && Timer < 15.2) // 10 soldiers created because I increase the second value number one.
        {
            //Instantiate(EnemySol, new Vector3(Random.Range(-2.65f, 2.65f), 0.6f, 23f), EnemySol.transform.rotation);
            SoldierNumber++;
            //Debug.Log(SoldierNumber + " olusturuldu");
        }
        if (Timer > 20 && Timer < 20.2) // 10 soldiers created because I increase the second value number one.
        {
            //Instantiate(EnemySol, new Vector3(Random.Range(-2.65f, 2.65f), 0.6f, 23f), EnemySol.transform.rotation);
            SoldierNumber++;
            //Debug.Log(SoldierNumber + " olusturuldu");
        }
        if (Timer > 25 && Timer < 25.4) // 20 soldiers created because I increase the second value number one.
        {
            //Instantiate(EnemySol, new Vector3(Random.Range(-2.65f, 2.65f), 0.6f, 23f), EnemySol.transform.rotation);
            SoldierNumber++;
            //Debug.Log(SoldierNumber + " olusturuldu");
        }
    }
    
    
}
