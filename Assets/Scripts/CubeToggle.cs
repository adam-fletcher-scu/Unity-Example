using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeToggle : MonoBehaviour
{
    public GameObject cube;
    

    public void ToggleMyCube()
    {
        if(cube.activeSelf)
        {
            cube.SetActive(false);  
        }
        else
        {
            cube.SetActive(true);
        }
    }
}
