using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skinChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject skin_Color;
    public GameObject list;
    public Material skin_mat;
    public Image sc;
    public Sprite skin1;
    public Sprite skin2;
    public Sprite skin3;
    public Sprite skin4;
    public Sprite skin5;
    public Sprite skin6;
    public Texture skin_1, skin_2, skin_3, skin_4, skin_5, skin_6;

    private void Start()
    {
        
    }
    public void onButtonClick()
    {
        foreach(Transform t in list.transform) {
            t.gameObject.SetActive(true);
        }
        list.SetActive(true);
    }
    private void hideAll()
    {
        foreach (Transform t in list.transform)
        {
            t.gameObject.SetActive(false);
        }
        list.SetActive(false);
    }
    public void sk1()
    {

        sc.sprite = skin1;
        skin_mat.SetTexture("_MainTex",skin_1);
        hideAll();
    }
    public void sk2()
    {
        sc.sprite = skin2;
        skin_mat.SetTexture("_MainTex", skin_2);
        hideAll();
    }
    public void sk3()
    {
        sc.sprite = skin3;
        skin_mat.SetTexture("_MainTex", skin_3);
        hideAll();
    }
    public void sk4()
    {
        sc.sprite = skin4;
        skin_mat.SetTexture("_MainTex", skin_4);
        hideAll();
    }
    public void sk5()
    {
        sc.sprite = skin5;
        skin_mat.SetTexture("_MainTex", skin_5);
        hideAll();
    }
    public void sk6()
    {
        sc.sprite = skin6;
        skin_mat.SetTexture("_MainTex", skin_6);
        hideAll();
    }
}
