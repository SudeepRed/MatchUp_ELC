using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CartAdder : MonoBehaviour
    
{
    // Start is called before the first frame update
    public static HashSet<string> Cart;
    public static int cartitems;
    private List<string> items;
    public TMP_Dropdown dd;
    public GameObject store;
    public GameObject vis;
    public GameObject model;
    public TMP_Text num;
    void Start()
    {
        Cart = new HashSet<string>();
        items = new List<string>();
        cartitems = 0;
    }

    // Update is called once per frame
    public void TShirt()
    {
        if (!Cart.Contains("T-Shirt"))
        {
            Cart.Add("T-Shirt");
            items.Add("T-Shirt");
        }
        cartitems += 1;
        num.text = "Cart : " + cartitems;
        
    }
    public void Dress()
    {
        if (!Cart.Contains("Dress"))
        {
            Cart.Add("Dress");
            items.Add("Dress");
        }
        cartitems += 1;
        num.text = "Cart : " + cartitems;
    }
    public void Skirt()
    {
        if (!Cart.Contains("Skirt"))
        {
            Cart.Add("Skirt");
            items.Add("Skirt");
        }
        
        cartitems += 1;
        num.text = "Cart : " + cartitems;
    }
    public void Visualize()
    {
        foreach (Transform t in store.transform)
        {
            t.gameObject.SetActive(false);
        }
        store.SetActive(false);
        foreach( Transform t in vis.transform)
        {
            t.gameObject.SetActive(true);
        }

        vis.SetActive(true);
        createDD();
    }
    void createDD()
    {
        dd.options.Clear();
        foreach(var item in items)
        {
            dd.options.Add(new TMP_Dropdown.OptionData() { text = item });
        }
        dropDownSelected(dd);
        dd.onValueChanged.AddListener(delegate { dropDownSelected(dd); }) ;
    }
    public void Store()
    {
        foreach (Transform t in store.transform)
        {
            t.gameObject.SetActive(true);
        }
        store.SetActive(true);
        foreach (Transform t in vis.transform)
        {
            t.gameObject.SetActive(false);
        }
        vis.SetActive(false);
    }
    void dropDownSelected(TMP_Dropdown dd)
    {
        int idx = dd.value;
        string s = dd.options[idx].text;
        showClothing(s);
    }
    private void showClothing(string s)
    {
        
        foreach(Transform t in model.transform)
        {
            if(t.tag=="Skirt" || t.tag=="T-Shirt" || t.tag == "Dress")
            {
                t.gameObject.SetActive(false);
            }
        }
        foreach (Transform t in model.transform)
        {
            if (t.tag == s)
            {
                t.gameObject.SetActive(true);
            }
        }

    }

}
