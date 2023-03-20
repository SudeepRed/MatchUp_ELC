using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SkinChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public Material suit;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void suColor()
    {
        string b = EventSystem.current.currentSelectedGameObject.name;
        if (b == "1")
        {
            Color mc = new Color();
            ColorUtility.TryParseHtmlString("#F5D4BB", out mc);
            suit.color = mc;
        }
        else if (b == "2")
        {
            Color mc = new Color();
            ColorUtility.TryParseHtmlString("#F1D0A7", out mc);
            suit.color = mc;
        }
        else if (b == "3")
        {
            Color mc = new Color();
            ColorUtility.TryParseHtmlString("#F5C492", out mc);
            suit.color = mc;
        }
        else if (b == "4")
        {
            Color mc = new Color();
            ColorUtility.TryParseHtmlString("#DBBA91", out mc);
            suit.color = mc;
        }
        else if (b == "5")
        {
            Color mc = new Color();
            ColorUtility.TryParseHtmlString("#E5CC9A", out mc);
            suit.color = mc;
        }
        else if (b == "6")
        {
            Color mc = new Color();
            ColorUtility.TryParseHtmlString("#DBB280", out mc);
            suit.color = mc;
        }
        else if (b == "7")
        {
            Color mc = new Color();
            ColorUtility.TryParseHtmlString("#DBAA78", out mc);
            suit.color = mc;
        }
        else if (b == "8")
        {
            Color mc = new Color();
            ColorUtility.TryParseHtmlString("#D09654", out mc);
            suit.color = mc;
        }
        else if (b == "9")
        {
            Color mc = new Color();
            ColorUtility.TryParseHtmlString("#C49250", out mc);
            suit.color = mc;
        }
        else if (b == "10")
        {
            Color mc = new Color();
            ColorUtility.TryParseHtmlString("#BA8047", out mc);
            suit.color = mc;
        }
        else if (b == "11")
        {
            Color mc = new Color();
            ColorUtility.TryParseHtmlString("#AA713F", out mc);
            suit.color = mc;
        }
        else if (b == "12")
        {
            Color mc = new Color();
            ColorUtility.TryParseHtmlString("#86542B", out mc);
            suit.color = mc;
        }

    }
}
