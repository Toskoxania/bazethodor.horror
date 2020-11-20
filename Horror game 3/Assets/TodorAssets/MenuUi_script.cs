using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuUi_script : MonoBehaviour
{
    public Text LoreText;
    public GameObject LoreTxt;
    public GameObject MenuTab;
    public bool acitveMenu = false;

    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;
    public GameObject obj6;
    public GameObject obj7;
    public GameObject obj8;
    public GameObject obj9;
    public GameObject obj10;
    public GameObject obj11;
    public GameObject obj12;

    private void Start()
    {
        MenuTab.SetActive(false);
        LoreTxt.SetActive(false);
    }
    private void Update()

    {
        if (Input.GetKeyDown(KeyCode.Tab) && !acitveMenu)
        {
            acitveMenu = true;
            Cursor.visible = acitveMenu;
            Cursor.lockState = CursorLockMode.Confined;
        }
        else if (Input.GetKeyDown(KeyCode.Tab) && acitveMenu)
        {
            Cursor.lockState = CursorLockMode.Locked;
            acitveMenu = false;
            Cursor.visible = acitveMenu;

        }
        MenuTab.SetActive(acitveMenu);
        
    }
    public void TextShower(bool active)
    {

        LoreTxt.SetActive(true);
        LoreText.text = "Your Objectives" +
            "1.find someone" +
            "2.find clues+" +
            "3.survive";
    }
    
    } 

    

 
