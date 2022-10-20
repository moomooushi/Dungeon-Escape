using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public string currentLevel;
    public void RestartMainLevel()
    {
        SceneManager.LoadScene(currentLevel);
        Time.timeScale = 1f;
    }
}
