using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject testObj;
    
    private GameObject stest;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void hideModel()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Fashion");
        foreach (GameObject enemy in enemies)
            Destroy(enemy);
    }
    // Update is called once per frame
    public void showModel()
        
    {
        Instantiate(testObj, transform.position, transform.rotation);
        //Sets "ChoiceButtonHolder" as the new parent of the s1Button.
        //stest.transform.SetParent(parentObj.transform);
    }
}
