using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2Tower : MonoBehaviour
{

    public GameObject EnemySolst2;

    public static int SoldierNumberS2;
    private float TimerSt2;


    // Start is called before the first frame update
    void Start()
    {
        SoldierNumberS2 = 0;


    }


    // Update is called once per frame
    void FixedUpdate()
    {

        TimerSt2 += Time.deltaTime;
        //Debug.Log(Timer);
        if (TimerSt2 > 2f && TimerSt2 < 2.1f) // 5 soldiers created 
        {
            Instantiate(EnemySolst2, new Vector3(Random.Range(-2.65f, 2.65f), 0.6f, 71f), EnemySolst2.transform.rotation);

            SoldierNumberS2++;
            //Debug.Log(SoldierNumber + " olusturuldu");

        }
        if (TimerSt2 > 5 && TimerSt2 < 5.2f) // 10 soldiers created because I increase the second value number one.
        {
            //Instantiate(EnemySolst2, new Vector3(Random.Range(-2.65f, 2.65f), 0.6f, 71f), EnemySolst2.transform.rotation);
            SoldierNumberS2++;
            //Debug.Log(SoldierNumber + " olusturuldu");
        }
        if (TimerSt2 > 10 && TimerSt2 < 10.3) // 15 soldiers created because I increase the second value number two.
        {
            //Instantiate(EnemySolst2, new Vector3(Random.Range(-2.65f, 2.65f), 0.6f, 71f), EnemySolst2.transform.rotation);
            SoldierNumberS2++;
            //Debug.Log(SoldierNumber + " olusturuldu");
        }
        if (TimerSt2 > 15 && TimerSt2 < 15.2) // 10 soldiers created because I increase the second value number one.
        {
            //Instantiate(EnemySolst2, new Vector3(Random.Range(-2.65f, 2.65f), 0.6f, 71f), EnemySolst2.transform.rotation);
            SoldierNumberS2++;
            //Debug.Log(SoldierNumber + " olusturuldu");
        }
        if (TimerSt2 > 20 && TimerSt2 < 20.2) // 10 soldiers created because I increase the second value number one.
        {
            //Instantiate(EnemySolst2, new Vector3(Random.Range(-2.65f, 2.65f), 0.6f, 71f), EnemySolst2.transform.rotation);
            SoldierNumberS2++;
            //Debug.Log(SoldierNumber + " olusturuldu");
        }
        if (TimerSt2 > 25 && TimerSt2 < 25.4) // 20 soldiers created because I increase the second value number one.
        {
            //Instantiate(EnemySolst2, new Vector3(Random.Range(-2.65f, 2.65f), 0.6f, 71f), EnemySolst2.transform.rotation);
            SoldierNumberS2++;
            //Debug.Log(SoldierNumber + " olusturuldu");
        }
    }


}
