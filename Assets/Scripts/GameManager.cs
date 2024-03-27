using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject panelSettings;
    public static int vidas = 3;

    public static int puntos = 3;

    void Awake(){
        DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("vidas:"+vidas); 
        if(Input.GetKeyDown(KeyCode.Space)){
            ToggleSettings();
        } 
    }

    public void ToggleSettings(){
        if(panelSettings.activeSelf == true){
            panelSettings.SetActive(false);
        
        }else{
            panelSettings.SetActive(true);
        }
    }
    
    public void GoToStart(){
        SceneManager.LoadScene("0inicio");
        panelSettings.SetActive(false);
    }

    public void ExitGame(){
        Application.Quit();
    }

    
    public void MostrarSettings(){
        panelSettings.SetActive(true);
    }

    public void OcultarSettings(){
        panelSettings.SetActive(false);
    }
}
