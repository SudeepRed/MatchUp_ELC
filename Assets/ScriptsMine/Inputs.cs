using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputs : MonoBehaviour
{
    public static string height;
    public static string weight;
    public static string chest;
    public static string hips;
    public static string inseam;
    public static string waist;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void getHeight(string s)
    {
        height = s;
        Debug.Log(height);
    }
    public void getWeight(string s)
    {
        weight = s;
    }
    public void getChest(string s)
    {
        chest = s;
    }
    public void getHips(string s)
    {
        hips = s;
    }
    public void getInseam(string s)
    {
        inseam = s;
    }
    public void getWaist(string s)
    {
        waist = s;
    }
}
