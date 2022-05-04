using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneCube : MonoBehaviour
{
    public GameObject ClonarCubito;

    public void CloneObject()
    {
        int i = 0;
        while (i < 3)
        {
            Instantiate(ClonarCubito);
            i++;
        }
            
    }
}
