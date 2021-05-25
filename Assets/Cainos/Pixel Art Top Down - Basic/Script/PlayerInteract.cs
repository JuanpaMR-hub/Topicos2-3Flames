using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{

    public GameObject currentInterObj = null;



    void Update(){
        
        if(Input.GetButtonDown("Interactuar")){
            if(currentInterObj.name == "HerbBossWarpPillar"){
                currentInterObj.SendMessage("Area_Hierba");
            }
            else if(currentInterObj.name == "WaterBossWarpPillar"){
                currentInterObj.SendMessage("Area_Agua");
            }
            else if(currentInterObj.name == "FireBossWarpPillar"){
                currentInterObj.SendMessage("Area_Fuego");
            }
        }
        
    }

    void OnTriggerEnter2D(Collider2D other){
       if (other.CompareTag("InterObject")){
           Debug.Log("Estas dentro del rango de" + other.name);
           currentInterObj = other.gameObject;
           currentInterObj.SendMessage("Brilla");
       }else if(other.CompareTag("Flames")){
           currentInterObj = other.gameObject;
           if(other.name == "Fuego1"){
               Debug.Log("Estas en la llama de Agua!");
               currentInterObj.SendMessage("Guardar_Agua");
           }else if(other.name == "Fuego2"){
               Debug.Log("Estas en la llama de Fuego!");
               currentInterObj.SendMessage("Guardar_Fuego");
           }
           
       }
   }

   void OnTriggerExit2D(Collider2D other){
       if(other.CompareTag("InterObject")){
           if(other.gameObject ==  currentInterObj ){
               currentInterObj.SendMessage("NoBrilla");
               currentInterObj = null;
               }        
       }
   }

   
}
