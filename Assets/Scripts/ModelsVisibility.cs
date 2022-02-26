// Andrea Sánchez, Alicia Pose and Rafael Moreta
// This script will load a model into the scene when the button is clicked. Models are instantiated as childs of "MultiTarget > Biomodels"

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using System.Linq;

public class ModelsVisibility : MonoBehaviour
{
    public string sceneName;
    public string modelsPath;
    public string energy;

    //private IsDisplacement isDisplaced;
    //private string buttonid;

    public List<Biomodel> completeBiomodels;
    private Biomodel curves_clone;

    //private Biomodel bone_clone;
    //private Biomodel tumor_clone;
    //public List<Biomodel> sguide_clone;
    //private Biomodel sguide_clone;

    //public Slider isodoseCurveSlider;

    //private string biomodel_name;
    //Color bonecolor;
    //Color tumorcolor;

    //bool isBoneVisible = true;
    //bool isSGuideVisible = true;
    //Material boneMat;
    //Material occlusionMat;
    //Material sguideMat;


    private void Start()
    {
        string path = "Assets/Resources/";
        string separe = "/";
        modelsPath = path + sceneName + separe + energy + separe;
        Debug.Log(modelsPath);
        LoadModelsIntoScene allbiomodels = new LoadModelsIntoScene(modelsPath, sceneName, energy); // Call the script "LoadModelsIntoScene" to instantiate all the biomodels with their corresponding texture
        completeBiomodels = allbiomodels.selectedBiomodels; // Take instances of all biomodels
        foreach (Biomodel item in completeBiomodels)
        {
            curves_clone = item;
            Debug.Log(curves_clone);
        }
        curves_clone.biomodel_gameObject.SetActive(true);
    }
}