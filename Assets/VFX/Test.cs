using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update

    public VisualEffect VisualEffect;

    public OpticalFlow.OpticalFlow OpticalFlow;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (VisualEffect != null)
        {
            if(OpticalFlow.flowBuffer!=null)
             VisualEffect.SetTexture("HeadCamTexture", OpticalFlow.flowBuffer);
        }
    }
}
