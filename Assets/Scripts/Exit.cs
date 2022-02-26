// Alicia Pose, Rafael Moreta y Andrea Sánchez
// Código para salir de la app al pulsar el botón de "Exit"

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    public void OnExitClick()
    {
        Application.Quit();
    }
}
