using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    
    public GameObject panelSettings;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        panelSettings.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void GoToLevelOne(){
        SceneManager.LoadScene("escena1");
    }

    public void ExitGame(){
        Application.Quit();
    }

   
    
}


