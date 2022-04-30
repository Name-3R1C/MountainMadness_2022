using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class moneyLeft : MonoBehaviour
{
    public int money = 20000;
    public Text moneyText;

    // Start is called before the first frame update
    void Start()
    {
        moneyText.text = "20,000";
    }
    public void updateMoney(){
        if(money > 0){
            money -= 500;
            if(money >= 1000){
                moneyText.text = Convert.ToString(money/1000) + ",000";
            }
            else{
                moneyText.text = money.ToString();
            }
        }
        // call for Game Over UI 
        // else{

        // }
        
    }
}
