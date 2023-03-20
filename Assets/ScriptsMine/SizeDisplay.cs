using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SizeDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    //<s ? 34
    //s: 34 to 35
    //m 36 37
    //l 38 39
    //xl 40 41
    //xxl 42 43
    //>xxl 43 55
    private string textValue;
    public Text textElement;
    private float chest = 0.0f;
    void Start()
    {
        chest = (FemaleShapeKey.chest + 233.33f) / 6.06f;
    }

    // Update is called once per frame
    void Update()
    {
        chest = (FemaleShapeKey.chest + 233.33f) / 6.06f;
        if (chest < 34)
        {
            textValue = "< S";
        }
        else if(chest < 35 && chest >= 34)
        {
            textValue = "S";
        }
        else if (chest < 37 && chest >= 35)
        {
            textValue = "M";
        }
        else if (chest < 39 && chest >= 37)
        {
            textValue = "L";
        }
        else if (chest < 41 && chest >= 39)
        {
            textValue = "XL";
        }
        else if (chest < 43 && chest >= 41)
        {
            textValue = "XXL";
        }
        else if (chest >= 43)
        {
            textValue = "> XXL";
        }
        textElement.text = textValue;
    }
}
