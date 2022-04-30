using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class endGameReason : MonoBehaviour
{
    public Text resaonText;
    public void timeEnd(){
        resaonText.text = "Need to Complete the Degree in Time!";
    }

    public void money(){
        resaonText.text = "Not enough money to continue";
    }
}
