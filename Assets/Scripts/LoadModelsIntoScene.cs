// Andrea Sánchez, Alicia Pose y Rafael Moreta
// Last edit: 23/02/2022
// Load the specified biomodels into the scene: This script specifically access to the folders of interest, 
// extracts all the biomodels and call the funcions "BiomodelMaterials" and "Biomodel" to assign a texture to each of them and instantiate them in the scene.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
public class LoadModelsIntoScene : MonoBehaviour
{
    public string sceneName;
    public string modelsPath;
    public GameObject[] sceneXBiomodels;
    public GameObject[] commonBiomodels;
    private List<GameObject> listOfGameObjects;
    public List<Biomodel> selectedBiomodels;
    public BiomodelMaterials correspondentMaterial;
    public string energy;

    // Function executed inside the code "ModelsAndUIVisibility"

    public LoadModelsIntoScene(string _modelsPath, string _sceneName, string _energy)
    {
        sceneName = _sceneName;
        modelsPath = _modelsPath;
        energy = _energy;
        string path = "Non-beveled/10MeV/";
        sceneXBiomodels = Resources.LoadAll(path, typeof(GameObject)).Cast<GameObject>().ToArray();
        //sceneXBiomodels = Resources.LoadAll(modelsPath, typeof(GameObject)).Cast<GameObject>().ToArray();
        


        //Put all biomodels together in a single list
        listOfGameObjects = new List<GameObject>();
        foreach (GameObject item in sceneXBiomodels)
        {
            
            listOfGameObjects.Add(item);
        }

        //Charge all properties in each biomodel
        selectedBiomodels = new List<Biomodel>();
        foreach (GameObject item in listOfGameObjects)
        {
            
            //Find the correspondent texture for each biomodel
            BiomodelMaterials biomat = new BiomodelMaterials(item, sceneName); // Call the script "BiomodelMaterials" to assign a texture to each biomodel
            

            //Create instances for all biomodels
            Biomodel oneBiomodel = new Biomodel(item, sceneName, modelsPath, biomat.material); // Call the script "Biomodel" to instantiate the biomodels in the scene
            selectedBiomodels.Add(oneBiomodel);
        }

    }
}
