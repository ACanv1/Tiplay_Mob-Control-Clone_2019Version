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
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        PuanText.text = "Score; " + Soldier.Puan;
        //PlayerPrefs.SetInt("Puan", Soldier.Puan);
        Coin = Soldier.Puan; 
        CoinText.text = "Coin " + Coin;
         TowerHealthText.text = Soldier.TowerHealth + "";
        if (Input.touchCount > 0)
        {
            Touch Finger = Input.GetTouch(0);
            if (Finger.phase == TouchPhase.Began)
            {
                //Panel.SetActive(false);
            }

        }

    }
}
