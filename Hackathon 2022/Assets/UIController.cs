using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    List<int> courses;

    int[] fullcrslist = { 120, 125, 225, 276, 300, 150, 152, 232, 316, 340, 103, 105, 201, 325, 428, 101, 110, 102, 105, 110 };
    GameObject[] coursesList;
    // Start is called before the first frame update
    void Start()
    {
        courses = new List<int>();
    }


    public void CollectItem(int item)
    {
        courses.Add(item);
    }

    // Update is called once per frame
    void Update()
    {
        int i = 0;

        bool exists = false;
       foreach (int course in fullcrslist)
        {
            foreach (int c in courses)
            {
                if (course == c)
                {
                    exists = true;
                    break;
                }
                    
            }

            if (exists)
                coursesList[i].SetActive(true);

            i++;
        }
    }
}
