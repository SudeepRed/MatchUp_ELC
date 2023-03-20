using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class HideElements : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject parent;
    public GameObject menu;
    //private void Start()
    //{
    //    parent = GetComponent<GameObject>();
    //}

    public void hideEverything()
    {
        foreach (Transform child in parent.transform)
        {
            
                child.gameObject.SetActive(false);
            


        }
        parent.SetActive(false);
        foreach(Transform child in menu.transform)
        {
            if (child.tag == "waist_button" && IntroSceneValueChanger.values.ContainsKey("waist"))
            {
                GameObject go = child.gameObject;
                foreach(Transform t in go.transform)
                {
                    TMP_Text x = t.gameObject.GetComponent<TMP_Text>();
                    x.text = Math.Round(IntroSceneValueChanger.values["waist"]) + "";
                    break;
                }
            }
            if(child.tag == "bust_button" && IntroSceneValueChanger.values.ContainsKey("bust"))
            {
                GameObject go = child.gameObject;
                foreach (Transform t in go.transform)
                {
                    TMP_Text x = t.gameObject.GetComponent<TMP_Text>();
                    x.text = Math.Round(IntroSceneValueChanger.values["bust"]) + "";
                    break;
                }
            }
            child.gameObject.SetActive(true);
        }
    }
   public void UnhideEverything()
    {
        //List<GameObject> Children= new List<GameObject>();

        foreach (Transform child in parent.transform)
        {
            if(child.tag!="Bust" && child.tag!="Waist"){
                child.gameObject.SetActive(true);
            }
             
            
        }
        parent.SetActive(true);
        foreach (Transform child in menu.transform)
        {
            child.gameObject.SetActive(false);
        }
    }
    public void showBustDetails()
    {
        foreach (Transform child in parent.transform)
        {
            if (child.tag == "Bust")
            {
                child.gameObject.SetActive(true);
            }
        }
    }
    public void showWaistDetails()
    {
        foreach (Transform child in parent.transform)
        {
            if (child.tag == "Waist")
            {
                child.gameObject.SetActive(true);
            }
        }
    }
}
