using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Proyecto26;
using System;

public class Login : MonoBehaviour
{

    public InputField textusername;
    public InputField textpassword;

    public static string username;
    public static string password;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void enviar(){
        username = textusername.text;
        password = textpassword.text;
        enviarPorPost();
    }

    public void enviarPorPost(){
        Usuario usuario = new Usuario();
        try{
            RestClient.Post("https://three-flames-default-rtdb.firebaseio.com/.json",usuario);
        }catch( Exception e ){
            Debug.Log(e.Message);
        }finally{
            textusername.text = "";
            textpassword.text = "";
        }
    }
}
