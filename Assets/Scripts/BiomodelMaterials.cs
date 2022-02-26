// Andrea Sánchez, Alicia Pose y Rafael Moreta
// Last edit: 23/02/2022
// Load a different texture for each biomodel 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BiomodelMaterials : MonoBehaviour
{
    public string biomodel;
    public string sceneName;
    public Material material;

    // This function is called from "LoadModelsIntoScene"
    public BiomodelMaterials(GameObject _biomodel, string _sceneName)
    {
        string initialstring = _biomodel.ToString();
        biomodel = initialstring.Split(' ')[0];
        sceneName = _sceneName;

        // Create 2 "if"s to assign a different material to a GameObject depending on the name 
        // of the Biomodel and the visualization mode scene
        if (biomodel.StartsWith("110-90"))
        {
            material = Resources.Load("110-90", typeof(Material)) as Material;
        }
        else if (biomodel.StartsWith("90-70"))
        {
                material = Resources.Load("90-70", typeof(Material)) as Material;
        }
        else if (biomodel.StartsWith("70-50"))
        {
                material = Resources.Load("70-50", typeof(Material)) as Material;
        }
        else if (biomodel.StartsWith("50-30"))
        {
                material = Resources.Load("50-30", typeof(Material)) as Material;
        }
        else if (biomodel.StartsWith("30-5"))
        {
            material = Resources.Load("30-5", typeof(Material)) as Material;
        }
    }
}
