using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string Scene1;
    public string Scene2;
    public string Scene3;
    public string Scene4;

    public void LoadScene1()
    {
        SceneManager.LoadScene(Scene1);
    }
    public void LoadScene2()
    {
        SceneManager.LoadScene(Scene2);
    }
    public void LoadScene3()
    {
        SceneManager.LoadScene(Scene3);
    }
    public void LoadScene4()
    {
        SceneManager.LoadScene(Scene4);
    }
}
