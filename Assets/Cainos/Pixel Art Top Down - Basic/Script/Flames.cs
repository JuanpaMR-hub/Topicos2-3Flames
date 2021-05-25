using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Proyecto26;
using System;

public class Flames : MonoBehaviour
{

    public static string llama;

    public void Guardar_Fuego(){
        Debug.Log("Has adquirido la llama de Fuego!");
        llama = "Fuego";
        }
    public void Guardar_Agua(){
        Debug.Log("Has adquirido la llama de Fuego!");
        llama = "Agua";
        }
        
    // public void guardar_llama(){
    //     usuario.LF = true;
    //     guardarPorPut();
    // }
    // public void guardarPorPut(){
    //     RestClient.Put("https://three-flames-default-rtdb.firebaseio.com/",usuario);
    // }

}
