using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changescene()
    {
        SceneManager.LoadScene("ChooseMenu");
    }
    public void changesceneStore()
    {
        SceneManager.LoadScene("Store");
    }
    public void changesceneEdit()
    {
        SceneManager.LoadScene("Measurements");
    }
}
