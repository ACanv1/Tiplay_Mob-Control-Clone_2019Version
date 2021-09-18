using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManage : MonoBehaviour
{
    public Text PuanText;
    public GameObject Panel;
    private int Coin = 0;
    public Text CoinText;
    public Text TowerHealthText;
    public Text TowerHealtTextSt2;
    public Text TowerHealthTextSt3;
    public GameObject Stage1;
    public GameObject Stage2;
    public GameObject Stage3;
    public GameObject Optimize;
    public GameObject Optimize2;
    public GameObject TowerMovement;
    

    // Start is called before the first frame update
    void Start()
    {
        Optimize.SetActive(false);
        Stage2.SetActive(false);
        Optimize2.SetActive(false);
        Stage3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        PuanText.text = "Score; " + Soldier.Puan;
        //PlayerPrefs.SetInt("Puan", Soldier.Puan);
        Coin = Soldier.Puan; 
        CoinText.text = "Coin " + Coin;
         TowerHealthText.text = Soldier.TowerHealth + "";
        TowerHealtTextSt2.text = Soldier.TowerHealthSt2 + "";
        TowerHealthTextSt3.text = Soldier.towerHealthSt3 + "";
        if (Input.touchCount > 0)
        {
            Touch Finger = Input.GetTouch(0);
            if (Finger.phase == TouchPhase.Began)
            {
                Panel.SetActive(false);
            }

        }
        if (Soldier.TowerHealth<=0)
        {

            //Stage1.SetActive(false);s
            Destroy(Stage1, 1f);
            Optimize.SetActive(true);
            Stage2.SetActive(true);
            
        }
        if (Soldier.TowerHealthSt2<=0)
        {
            Destroy(Stage2, 1f);
            Stage3.SetActive(true);
            Optimize2.SetActive(true);
        }
        if (Soldier.towerHealthSt3<=0)
        {
            Destroy(Stage3, 1f);
            
        }
        
        

        

    }
}
