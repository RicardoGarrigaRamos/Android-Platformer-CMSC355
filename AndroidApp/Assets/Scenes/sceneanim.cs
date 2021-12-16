using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneanim : MonoBehaviour
{
    public Animator transitionAnim;
    public string sceneName;

    void Update(){
        LoadNextLevel();
    }
    public void LoadNextLevel(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
       
}
