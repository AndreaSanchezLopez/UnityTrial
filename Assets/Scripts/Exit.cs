// Alicia Pose, Rafael Moreta y Andrea S�nchez
// C�digo para salir de la app al pulsar el bot�n de "Exit"

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
