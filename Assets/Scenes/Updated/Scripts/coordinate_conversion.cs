using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
public class coordinate_conversion : MonoBehaviour
{
    // Start is called before the first frame update
    public Button b;
    public Camera c;
    public TMP_InputField inp;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = c.WorldToScreenPoint(this.transform.position);
        if(b!=null)
            b.transform.position = pos;
        if(inp!=null)
            inp.transform.position = pos;
    }
}
