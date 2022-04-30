using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transitions : MonoBehaviour
{
    public GameObject[] enable;

    public GameObject[] disable;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void ED()
    {
        foreach (GameObject e in enable)
        {
            e.SetActive(true);

        }

        foreach (GameObject d in disable)
        {
            d.SetActive(false);

        }

    }
}
