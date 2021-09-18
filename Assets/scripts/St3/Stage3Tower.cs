using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3Tower : MonoBehaviour
{

    public GameObject EnemySolst3;

    public static int SoldierNumberS3;
    private float TimerSt3;


    // Start is called before the first frame update
    void Start()
    {
        SoldierNumberS3 = 0;


    }


    // Update is called once per frame
    void FixedUpdate()
    {

        TimerSt3 += Time.deltaTime;
        //Debug.Log(Timer);
        if (TimerSt3 > 2f && TimerSt3 < 2.1f) // 5 soldiers created 
        {
            Instantiate(EnemySolst3, new Vector3(Random.Range(-2.65f, 2.65f), 0.6f, 118f), EnemySolst3.transform.rotation);

            SoldierNumberS3++;
            //Debug.Log(SoldierNumber + " olusturuldu");

        }
        if (TimerSt3 > 5 && TimerSt3 < 5.2f) // 10 soldiers created because I increase the second value number one.
        {
            Instantiate(EnemySolst3, new Vector3(Random.Range(-2.65f, 2.65f), 0.6f, 118f), EnemySolst3.transform.rotation);
            SoldierNumberS3++;
            //Debug.Log(SoldierNumber + " olusturuldu");
        }
        if (TimerSt3 > 10 && TimerSt3 < 10.3) // 15 soldiers created because I increase the second value number two.
        {
            Instantiate(EnemySolst3, new Vector3(Random.Range(-2.65f, 2.65f), 0.6f, 118f), EnemySolst3.transform.rotation);
            SoldierNumberS3++;
            //Debug.Log(SoldierNumber + " olusturuldu");
        }
        if (TimerSt3 > 15 && TimerSt3 < 15.2) // 10 soldiers created because I increase the second value number one.
        {
            Instantiate(EnemySolst3, new Vector3(Random.Range(-2.65f, 2.65f), 0.6f, 118f), EnemySolst3.transform.rotation);
            SoldierNumberS3++;
            //Debug.Log(SoldierNumber + " olusturuldu");
        }
        if (TimerSt3 > 20 && TimerSt3 < 20.2) // 10 soldiers created because I increase the second value number one.
        {
            Instantiate(EnemySolst3, new Vector3(Random.Range(-2.65f, 2.65f), 0.6f, 118f), EnemySolst3.transform.rotation);
            SoldierNumberS3++;
            //Debug.Log(SoldierNumber + " olusturuldu");
        }
        if (TimerSt3 > 25 && TimerSt3 < 25.4) // 20 soldiers created because I increase the second value number one.
        {
            Instantiate(EnemySolst3, new Vector3(Random.Range(-2.65f, 2.65f), 0.6f, 118f), EnemySolst3.transform.rotation);
            SoldierNumberS3++;
            //Debug.Log(SoldierNumber + " olusturuldu");
        }
    }


}
