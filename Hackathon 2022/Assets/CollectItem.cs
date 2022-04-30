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

    public float timeOut = 0;

    public AudioSource src;

    public bool hit;


    private void OnEnable()
    {
     //   textelement.text = CourseDesc;
    }
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == PlayerName && timeOut <= 0)
        {
            mainController.CollectItem(value);
            src.Play();
            // this.gameObject.SetActive(false);
            timeOut = 3;
        }
    }

    private void Update()
    {
        // test
        if (hit)
        {
            mainController.CollectItem(value);
            src.Play();
            //  this.gameObject.SetActive(false);
            hit = false;
        }

        if (timeOut > 0)
        {
            timeOut -= Time.deltaTime;
        }
    }
}
