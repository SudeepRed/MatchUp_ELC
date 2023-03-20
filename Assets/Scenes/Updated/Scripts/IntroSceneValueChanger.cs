using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;
using TMPro;
using System.Globalization;

public class IntroSceneValueChanger: MonoBehaviour

{
    private SkinnedMeshRenderer skmr;
    public GameObject waist_target;
    public GameObject bust_target;
    public GameObject main_pos;
    public static Dictionary<string, float> values;
    public Camera main;
    public Slider waistSlider;
    public Slider bustSlider;
    public TMP_InputField height;
    public TMP_InputField weight;
    private Vector3 waist_target_pos;
    private Vector3 main_camera_pos;
    private Vector3 bust_target_pos;
    // Start is called before the first frame update
    void Start()
    {
        skmr = GetComponent<SkinnedMeshRenderer>();
        waist_target_pos = waist_target.transform.position;
        main_camera_pos = main.transform.position;
        bust_target_pos = bust_target.transform.position;
        values = new Dictionary<string, float>();
    }

    // Update is called once per frame

    public void waist()
    {

        main.transform.position = waist_target_pos;
            
        
       
    }
    public void bust()
    {

        main.transform.position = bust_target_pos;



    }

    public void waistValueChange()
    {
        float waist = waistSlider.value;
        Debug.Log(waist);
        if (values.ContainsKey("waist"))
        {
            values["waist"] = waist;
        }
        else
        values.Add("waist", waist);
        //(waist)=(waist + 190.91f) / 6.06f ;
        GameObject s = waistSlider.gameObject;
        //(waist)=(waist + 190.91f) / 6.06f ;
        foreach (Transform t in s.transform)
        {
            if (t.tag == "waist_val")
            {
                TMP_Text k = t.gameObject.GetComponent<TMP_Text>();
                k.text = Math.Round(waist, 2) + "' in";
                break;
            }
        }
        Calc(10, 11, waist);



    }
    public void heightValueChange()
    {
        float h = float.Parse(height.text, CultureInfo.InvariantCulture);
        Debug.Log(h);
        if (values.ContainsKey("height"))
        {
            values["height"] = h;
        }
        else
            values.Add("height", h);
        //(waist)=(waist + 190.91f) / 6.06f ;
        Calc(0, 1, h);



    }
    public void weightValueChange()
    {
        float w = float.Parse(weight.text, CultureInfo.InvariantCulture);
        Debug.Log(w);
        if (values.ContainsKey("weight"))
        {
            values["weight"] = w;
        }
        else
            values.Add("weight", w);
        //(waist)=(waist + 190.91f) / 6.06f ;
        Calc(2, 3, w);



    }
    public void bustValueChange()
    {
        float bust = bustSlider.value;
        Debug.Log(bust);
        if (values.ContainsKey("bust"))
        {
            values["bust"] = bust;
        }
        else
            values.Add("bust", bust);
        GameObject s = bustSlider.gameObject;
        //(waist)=(waist + 190.91f) / 6.06f ;
        foreach(Transform t in s.transform)
        {
            if (t.tag == "bust_val")
            {
                TMP_Text k = t.gameObject.GetComponent<TMP_Text>();
                k.text = Math.Round(bust,2) + "' in";
                break;
            }
        }
        Calc(15, 14, bust);



    }
    private void Calc(int i,int j ,float val)
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
            skmr.SetBlendShapeWeight(j, 0);
            skmr.SetBlendShapeWeight(i, 0);
        }
    }



    public void Close()
    {
        main.transform.position = main_camera_pos;


    }
    void Update()
    {

            

        
    }
}
