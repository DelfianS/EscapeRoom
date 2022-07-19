using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Keypad : Interactable
{
    
    private GameObject keypad;
    private GameObject B1;
    private GameObject B2;
    private GameObject B3;
    private GameObject B4;
    private GameObject B5;
    private GameObject B6;
    private GameObject B7;
    private GameObject B8;
    private GameObject B9;
    private GameObject B0;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void Interact()
    {
        SceneManager.LoadScene("Demo");
    }
}
