
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_script_ba : MonoBehaviour
{
    // Start is called before the first frame update
    
    public int realHeight = 55;
    public int realWeight = 30;
    public int realChest = 22;
    public int realHips = 26;
    public int realInseam = 22;
    public int realWaist = 15;
    private bool heightChosen = false;
    private bool weightChosen = false;
    private bool WaistChosen = false;
    private bool chestChosen = false;
    private bool hipsChosen = false;
    private bool InseamChosen = false;
    float height = 0.0f;
    float weight = 0.0f;
    float shoulder = 0.0f;
    public static float chest = 0.0f;
    float waist = 0.0f;
    float hips = 0.0f;
    float inseam = 0.0f;
    float muscle = 0.0f;
    private float x = 0.0f;
    private float l = 0;

    SkinnedMeshRenderer skmr;
    void Start()
    {

        //realHeight = int.Parse(Inputs.height);
        //realWeight = int.Parse(Inputs.weight);
        //realChest = int.Parse(Inputs.chest);
        ////     realHips = int.Parse(Inputs.hips);
        ////     realInseam = int.Parse(Inputs.inseam);
        //realWaist = int.Parse(Inputs.waist);

        x = Screen.height / 10;
        l = Screen.width / 5;
        skmr = GetComponent<SkinnedMeshRenderer>();

    }
    //(Mathf.Round(TimeTaken * 100)) / 100.0

    // Update is called once per frame
    void heightCalc(int i, int j)
    {
        Debug.Log(skmr.GetBlendShapeWeight(i));
        if (realHeight < 0)
        {
            skmr.SetBlendShapeWeight(i, -realHeight);
            skmr.SetBlendShapeWeight(j, 0);
            
        }
        else if (realHeight > 0)
        {
            skmr.SetBlendShapeWeight(j, realHeight);
            skmr.SetBlendShapeWeight(i, 0);
        }
        else
        {
            skmr.SetBlendShapeWeight(i, 0);
            skmr.SetBlendShapeWeight(j, 0);
        }
    }
    void weightCalc(int i, int j)
    {
        if (weight < 0)
        {
            skmr.SetBlendShapeWeight(i, -weight);
            skmr.SetBlendShapeWeight(j, 0);
        }
        else if (weight > 0)
        {
            skmr.SetBlendShapeWeight(j, weight);
            skmr.SetBlendShapeWeight(i, 0);
        }
        else
        {
            skmr.SetBlendShapeWeight(i, 0);
            skmr.SetBlendShapeWeight(j, 0);
        }
    }
    void shoulderCalc(int i, int j)
    {
        if (shoulder < 0)
        {
            skmr.SetBlendShapeWeight(i, -shoulder);
            skmr.SetBlendShapeWeight(j, 0);
        }
        else if (shoulder > 0)
        {
            skmr.SetBlendShapeWeight(j, shoulder);
            skmr.SetBlendShapeWeight(i, 0);
        }
        else
        {
            skmr.SetBlendShapeWeight(i, 0);
            skmr.SetBlendShapeWeight(j, 0);
        }
    }
    void chestCalc(int i, int j)
    {
        if (chest < 0)
        {
            skmr.SetBlendShapeWeight(i, -chest);
            skmr.SetBlendShapeWeight(j, 0);
        }
        else if (chest > 0)
        {
            skmr.SetBlendShapeWeight(j, chest);
            skmr.SetBlendShapeWeight(i, 0);
        }
        else
        {
            skmr.SetBlendShapeWeight(i, 0);
            skmr.SetBlendShapeWeight(j, 0);
        }
    }
    void waistCalc(int i, int j)
    {
        if (waist < 0)
        {
            skmr.SetBlendShapeWeight(i, -waist);
            skmr.SetBlendShapeWeight(j, 0);
        }
        else if (waist > 0)
        {
            skmr.SetBlendShapeWeight(j, waist);
            skmr.SetBlendShapeWeight(i, 0);
        }
        else
        {
            skmr.SetBlendShapeWeight(i, 0);
            skmr.SetBlendShapeWeight(j, 0);
        }
    }
    void hipsCalc(int i, int j)
    {
        if (hips < 0)
        {
            skmr.SetBlendShapeWeight(i, -hips);
            skmr.SetBlendShapeWeight(j, 0);
        }
        else if (hips > 0)
        {
            skmr.SetBlendShapeWeight(j, hips);
            skmr.SetBlendShapeWeight(i, 0);
        }
        else
        {
            skmr.SetBlendShapeWeight(i, 0);
            skmr.SetBlendShapeWeight(j, 0);
        }
    }
    void inseamCalc(int i, int j)
    {
        if (inseam < 0)
        {
            skmr.SetBlendShapeWeight(i, -inseam);
            skmr.SetBlendShapeWeight(j, 0);
        }
        else if (inseam > 0)
        {
            skmr.SetBlendShapeWeight(j, inseam);
            skmr.SetBlendShapeWeight(i, 0);
        }
        else
        {
            skmr.SetBlendShapeWeight(i, 0);
            skmr.SetBlendShapeWeight(j, 0);
        }
    }
    void muscleCalc(int i, int j)
    {
        if (muscle < 0)
        {
            skmr.SetBlendShapeWeight(i, -muscle);
            skmr.SetBlendShapeWeight(j, 0);
        }
        else if (muscle > 0)
        {
            skmr.SetBlendShapeWeight(j, muscle);
            skmr.SetBlendShapeWeight(i, 0);
        }
        else
        {
            skmr.SetBlendShapeWeight(i, 0);
            skmr.SetBlendShapeWeight(j, 0);
        }
    }


    void measurementMath()
    {
        if (!heightChosen)
        {
            height = 8.33333f * (realHeight) - 550;

        }
        if (!weightChosen)
        {
            weight = 1.37f * (realWeight) - 71.05f;

        }
        if (!chestChosen)
        {
            chest = 6.06f * (realChest) - 233.33f;

        }
        if (!hipsChosen)
        {
            hips = 6.45f * (realHips) - 267.74f;

        }
        if (!InseamChosen)
        {
            inseam = 11.76f * (realInseam) - 358.82f;

        }
        if (!WaistChosen)
        {
            waist = 6.06f * (realWaist) - 190.91f;

        }
    }
    void Update()
    {


        //Debug.Log(realHeight);
        heightCalc(0, 1);
        weightCalc(2, 3);
        inseamCalc(4, 5);
        muscleCalc(6, 7);
        hipsCalc(8, 9);
        waistCalc(10, 11);
        shoulderCalc(12, 13);
        chestCalc(14, 15);

    }
}
