using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Materialchanger : MonoBehaviour
{
    // Start is called before the first frame update
    public Material jacket;
    public Material dress;
    public Material skirt;
    public Material suit;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void suColor()
    {
        string b = EventSystem.current.currentSelectedGameObject.name;
        if (b == "Button1")
        {
            Color mc = new Color();
            ColorUtility.TryParseHtmlString("#161616", out mc);
            suit.color = mc;
        }
        else if (b == "Button2")
        {
            Color mc = new Color();
            ColorUtility.TryParseHtmlString("#26316A", out mc);
            suit.color = mc;
        }
    }
    public void jColor()
    {
        string b = EventSystem.current.currentSelectedGameObject.name;
        if (b == "Button1")
        {
            Color mc = new Color();
            ColorUtility.TryParseHtmlString("#BC9900", out mc);
            jacket.color = mc;
        }
        else if (b == "Button2")
        {
            Color mc = new Color();
            ColorUtility.TryParseHtmlString("#475395", out mc);
            jacket.color = mc;
        }
    }
    public void sColor()
    {
        string b = EventSystem.current.currentSelectedGameObject.name;
        if (b == "Button1")
        {
            Color mc = new Color();
            ColorUtility.TryParseHtmlString("#FF4C4C", out mc);
            skirt.color = mc;
        }
        else if (b == "Button2")
        {
            Color mc = new Color();
            ColorUtility.TryParseHtmlString("#479593", out mc);
            skirt.color = mc;
        }
    }
    public void dColor()
    {
        string b = EventSystem.current.currentSelectedGameObject.name;
        if (b == "Button1")
        {
            Color mc = new Color();
            ColorUtility.TryParseHtmlString("#323271", out mc);
            dress.color = mc;
        }
        else if (b == "Button2")
        {
            Color mc = new Color();
            ColorUtility.TryParseHtmlString("#954793", out mc);
            dress.color = mc;
        }
    }
}
