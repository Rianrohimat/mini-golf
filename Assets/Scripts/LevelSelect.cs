using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void hole1()
    {
        SceneManager.LoadScene("hole1");
    }

    public void hole2()
    {
        SceneManager.LoadScene("hole2");
    }
    public void hole3()
    {
        SceneManager.LoadScene("hole3");
    }
}
