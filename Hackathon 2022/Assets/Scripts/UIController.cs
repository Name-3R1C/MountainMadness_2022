using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    List<int> courses;
    int[] courseCount = new int[4];

    int cash = 2000;

    int[] fullcrslist = { 120, 125, 225, 276, 300, 150, 152, 232, 316, 340, 103, 105, 201, 325, 428, 101, 110, 202, 210, 310 };
    public Text[] CourseHeaders;
    public GameObject[] coursesList;
    public GameObject SubUI;
    public CameraControl cameraCtr;
    public GameObject pauseUI;
    public GameObject GradAnim;
    public GraduateBarrier barrier;
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
        cash -= 400;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxis("Cancel") != 0)
        {
            pauseUI.SetActive(true);
        }

        if (cash < 0)
        {
            reason.money();
            cameraCtr.MoveCamera = true;
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

        int total = (int)(courseCount[0] + courseCount[1] + courseCount[2] + courseCount[3]);
        CourseHeaders[0].text = "CMPT (" + courseCount[0] + "/5)";
        CourseHeaders[1].text = "MATH (" + courseCount[1] + "/5)";
        CourseHeaders[2].text = "ECON (" + courseCount[2] + "/5)";
        CourseHeaders[3].text = "PHYS (" + courseCount[3] + "/5)";


        if (courseCount[0] == 5 || courseCount[1] == 5 || courseCount[2] == 5 || courseCount[3] == 5)
        {
            GradAnim.SetActive(true);
            barrier.AllowExit();
        }

        listCrcs.text = "Total Courses Finished: " + total;
        cashCount.text = "$" + cash.ToString();
    }
}
