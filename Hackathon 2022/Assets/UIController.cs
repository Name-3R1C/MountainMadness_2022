using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    List<int> courses;
    int[] courseCount = new int[4];

    int cash = 20000;

    int[] fullcrslist = { 120, 125, 225, 276, 300, 150, 152, 232, 316, 340, 103, 105, 201, 325, 428, 101, 110, 102, 105, 110 };
    public Text[] CourseHeaders;
    public GameObject[] coursesList;
    public GameObject SubUI;
    public GameObject pauseUI;
    public endGameReason reason;

    public Text cashCount;
    public Text listCrcs;
    // Start is called before the first frame update
    void Start()
    {
        courses = new List<int>();
    }


    public void CollectItem(int item)
    {
        courses.Add(item);
        cash -= 500;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxis("Cancel") != 0)
        {
            pauseUI.SetActive(true);
        }

        if (cash <= 0)
        {
            reason.money();
            SubUI.SetActive(true);
            gameObject.SetActive(false);
        }

        int i = 0;
        int count = 0;
        bool exists = false;
        foreach (int course in fullcrslist)
        {
            exists = false;
            foreach (int c in courses)
            {
                if (course == c)
                {
                    exists = true;
                    break;
                }

            }

            if (exists)
            {
                if (!coursesList[i].activeSelf)
                {
                    coursesList[i].SetActive(true);
                    courseCount[count]++;
                }
            }

            i++;

            if (i % 5 == 0)
            {
                count++;
            }
        }

        CourseHeaders[0].text = "CMPT (" + courseCount[0] + "/5)";
        CourseHeaders[1].text = "MATH (" + courseCount[1] + "/5)";
        CourseHeaders[2].text = "ECON (" + courseCount[2] + "/5)";
        CourseHeaders[3].text = "PHYS (" + courseCount[3] + "/5)";

        listCrcs.text = "Total Courses: " + (int)(courseCount[0] + courseCount[1] + courseCount[2] + courseCount[3]) + "/20";
        cashCount.text = "$" + cash.ToString();
    }
}
