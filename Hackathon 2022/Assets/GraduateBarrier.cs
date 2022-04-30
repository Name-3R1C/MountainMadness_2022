using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraduateBarrier : MonoBehaviour
{
    BoxCollider[] barriers;


    private void OnTriggerEnter(Collider other)
    {
        
    }

    // Start is called before the first frame update
    public void AllowExit()
    {
        foreach (BoxCollider boxc in barriers)
        {
            boxc.isTrigger = true;
        }
    }
}
