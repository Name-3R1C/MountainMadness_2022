using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartEndGame : MonoBehaviour
{
    void Start() {
        
    }
    
    void Update() {

    }
    public void RestartGame() {
             SceneManager.LoadScene("Intro");
         }
    public void endGame(){
         Application.Quit();
    }   
}
