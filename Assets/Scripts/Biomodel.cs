// Andrea Sánchez, Alicia Pose and Rafael Moreta
// Last edit: 23/02/2022
// This script is called from "LoadModelsIntoScene". On it, the biomodels of interest are instantiated as childs of "MultiTarget > Biomodels"

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Biomodel : MonoBehaviour
{
    public string biomodelName;
    public GameObject biomodel_gameObject;
    public string sceneName;
    public string modelsPath;
    public GameObject biomodel_clone;
    public Material biomodelMaterial;
    private GameObject biomodelsInMultitarget;

    public Biomodel(GameObject _biomodel, string _sceneName, string _modelsPath, Material _material)
    {
        //Assign names to the variables since they are inputs that have different names
        string initialstring = _biomodel.ToString();
        biomodelName = initialstring.Split(' ')[0];
        biomodel_gameObject = _biomodel;
        sceneName = _sceneName;
        modelsPath = _modelsPath;
        biomodelMaterial = _material;

        //Load biomodel and Instantiate Clone in Multitarget
        biomodel_clone = Instantiate(biomodel_gameObject) as GameObject;
        biomodelsInMultitarget = GameObject.Find("Biomodels");
        biomodel_clone.transform.parent = biomodelsInMultitarget.transform;
        biomodel_clone.GetComponentInChildren<Renderer>().material = biomodelMaterial;
        biomodel_gameObject = biomodel_clone;
        Debug.Log(biomodel_gameObject.name);
    }
}

