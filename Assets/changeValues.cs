using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeValues : MonoBehaviour
{
    // Start is called before the first frame update
    private SkinnedMeshRenderer model;
    void Start()
    {
        model = GetComponent<SkinnedMeshRenderer>();
        changeParametera();
    }
    public  void changeParametera()
    {
        float height, weight, bust, hips, inseam, waist;
        Dictionary<string, float> d = IntroSceneValueChanger.values;
        if (d.ContainsKey("height"))
        {
            height = 8.33333f * (d["height"]) - 550;
            calc(0, 1, IntroSceneValueChanger.values["height"], model);

        }
        if (d.ContainsKey("weight"))
        {
            weight = 1.37f * (d["weight"]) - 71.05f;
            calc(2, 3, weight, model);

        }
        if (d.ContainsKey("bust"))
        {
            bust = 6.06f * (d["bust"]) - 233.33f;
            calc(14, 15, bust, model);

        }
        if (d.ContainsKey("hips"))
        {
            hips = 6.45f * (d["hips"]) - 267.74f;
            calc(8, 9, hips, model);

        }
        if (d.ContainsKey("inseam"))
        {
            inseam = 11.76f * (d["inseam"]) - 358.82f;
            calc(4, 5, inseam, model);

        }
        if (d.ContainsKey("waist"))
        {
            waist = 6.06f * (d["waist"]) - 190.91f;
            calc(10, 11, waist, model);

        }

        foreach (Transform t in model.transform)
        {
            SkinnedMeshRenderer skmr = t.gameObject.GetComponent<SkinnedMeshRenderer>();
            
            
            if (d.ContainsKey("height"))
            {
                height = 8.33333f * (d["height"]) - 550;
                calc(0, 1, IntroSceneValueChanger.values["height"], skmr);

            }
            if (d.ContainsKey("weight"))
            {
                weight = 1.37f * (d["weight"]) - 71.05f;
                calc(2, 3,weight, skmr);

            }
            if (d.ContainsKey("bust"))
            {
                bust = 6.06f * (d["bust"]) - 233.33f;
                calc(14, 15, bust, skmr);

            }
            if (d.ContainsKey("hips"))
            {
                hips = 6.45f * (d["hips"]) - 267.74f;
                calc(8, 9, hips, skmr);

            }
            if (d.ContainsKey("inseam"))
            {
                inseam = 11.76f * (d["inseam"]) - 358.82f;
                calc(4, 5, inseam, skmr);

            }
            if (d.ContainsKey("waist"))
            {
                waist = 6.06f * (d["waist"]) - 190.91f;
                calc(10, 11, waist, skmr);

            }
            //heightCalc(0, 1);
            //weightCalc(2, 3);
            //inseamCalc(4, 5);
            //muscleCalc(6, 7);
            //hipsCalc(8, 9);
            //waistCalc(10, 11);
            //shoulderCalc(12, 13);
            //chestCalc(14, 15);


        }
    }
    void calc(int i, int j, float val, SkinnedMeshRenderer skmr)
    {
        if (val < 0)
        {
            skmr.SetBlendShapeWeight(i, -val);
            skmr.SetBlendShapeWeight(j, 0);
        }
        else if (val > 0)
        {
            skmr.SetBlendShapeWeight(j, val);
            skmr.SetBlendShapeWeight(i, 0);
        }
        else
        {
            skmr.SetBlendShapeWeight(i, 0);
            skmr.SetBlendShapeWeight(j, 0);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
