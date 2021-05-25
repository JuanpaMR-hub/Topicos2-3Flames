using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Usuario 
{

    public string nombreUsuario;
    public string passUsuario;
    public bool LH;
    public bool LA;
    public bool LF;

    public Usuario(){
        nombreUsuario = Login.username;
        passUsuario = Login.password;
        LH = false;
        LA = false;
        LF = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
