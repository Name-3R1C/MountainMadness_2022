using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject e;
    public GameObject d;

    public void Trans() {
        e.SetActive(true);
        d.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}