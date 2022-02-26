// Andrea Sánchez y Alicia Pose
// Last edit: 15/02/2022

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    public void onClick(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
