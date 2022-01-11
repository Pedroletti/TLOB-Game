using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoOutside2 : MonoBehaviour
{
    public int loadLevel;

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(loadLevel);
    }
}
