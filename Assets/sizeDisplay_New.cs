using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class sizeDisplay_New : MonoBehaviour
{
    // Start is called before the first frame update
    float chest = 0;
    //float shoulder = IntroSceneValueChanger.values["shoulder"];

    void Start()
    {
        chest = IntroSceneValueChanger.values["bust"];
        TMP_Text t = GetComponent<TMP_Text>();
        if (chest <= 32)
        {
            t.text += "XS"; 
        }
        else if( chest>32 && chest <= 34)
        {
            t.text += "S";
        }
        else if (chest >34 && chest <= 36)
        {
            t.text += "M";
        }
        else if(chest>36 && chest <= 38)
        {
            t.text += "L";
        }
        else if(chest>38 && chest <= 40)
        {
            t.text += "XL";
        }
        else
        {
            t.text += ">XL";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
