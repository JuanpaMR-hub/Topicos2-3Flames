using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WarpPillar : MonoBehaviour {
    
    public GameObject pillar;
    public GameObject glow;
    [SerializeField] private string newlevel;
 
    public void Brilla(){
        glow = pillar.transform.Find("Glow").gameObject;
        glow.SetActive(true);
        // SceneManager.LoadScene(newlevel);
    }
    public void NoBrilla(){
        glow.SetActive(false);
        glow = null;
    }
    public void Area_Hierba(){
        Debug.Log("Hola, aqui está el Jefe de Hierba");
    }
    public void Area_Agua(){
        Debug.Log("Hola, aqui está el Jefe de Agua");
    }
    public void Area_Fuego(){
        Debug.Log("Hola, aqui está el Jefe de Fuego");
    }
}
