using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeSCreen : MonoBehaviour
{
    // Start is called before the first frame update
  public void changeToNonAR()
    {
        SceneManager.LoadScene("NonAR");
    }
    public void changetoAR()
    {
        SceneManager.LoadScene("ARGroundPlane");
    }
}
