using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class heightSlider : MonoBehaviour
{
    public Slider s;
    
    private SkinnedMeshRenderer skmr;
    // Start is called before the first frame update
    void Start()
    {
        
        skmr = GetComponent<SkinnedMeshRenderer>();
    }

    // Update is called once per frame
    void heightCalc(int i, int j)
    {
        float height = s.value;
        Debug.Log(height);
        if (height < 0)
        {
            skmr.SetBlendShapeWeight(i, -height);
            skmr.SetBlendShapeWeight(j, 0);
        }
        else if (height > 0)
        {
            skmr.SetBlendShapeWeight(j, height);
            skmr.SetBlendShapeWeight(i, 0);
        }
        else
        {
            skmr.SetBlendShapeWeight(i, 0);
            skmr.SetBlendShapeWeight(j, 0);
        }
    }
    void Update()
    {
        heightCalc(0, 1);
    }
}
