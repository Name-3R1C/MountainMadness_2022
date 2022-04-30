using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Course : MonoBehaviour
{
    public int courseCompleted = 0;
    public Text courseCompletedText;
    
    void Start()
    {
        courseCompletedText.text = "Total Courses Complete: 0/8";
    }

    public void updateCourse(){
        courseCompleted += 1;
        courseCompletedText.text = "Total Courses Complete: " + courseCompleted.ToString() + "/8";
    }
}
