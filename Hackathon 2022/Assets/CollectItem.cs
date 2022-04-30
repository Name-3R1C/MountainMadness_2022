using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectItem : MonoBehaviour
{

    public UIController mainController;
   // public TextMesh textelement;

    public string CourseDesc = "CMPT 125";
    public string PlayerName = "Player";
    public int value;


    private void OnEnable()
    {
     //   textelement.text = CourseDesc;
    }
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == PlayerName)
        {
            mainController.CollectItem(value);
            this.gameObject.SetActive(false);
        }
    }
}
