using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GraduateBarrier : MonoBehaviour
{
    public BoxCollider[] barriers;
    public MeshRenderer[] renderers;
    public Material active;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Outro");
    }

    // Start is called before the first frame update
    public void AllowExit()
    {
        foreach (BoxCollider boxc in barriers)
        {
            boxc.isTrigger = true;
        }

        foreach (MeshRenderer rendererO in renderers)
        {
            rendererO.material = active;
        }
    }
}
