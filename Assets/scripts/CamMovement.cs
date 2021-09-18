using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Soldier.TowerHealth<=0)
        {
            Anim.SetBool("Stage1", true);
        }
    }
}
