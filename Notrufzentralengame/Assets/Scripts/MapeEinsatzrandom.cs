using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapeEinsatzrandom : MonoBehaviour
{
    public Image Einsatzimage;

    public void click()
    {
        int Xrandom = Random.Range(-236, 236);
        int Yrandom = Random.Range(-151, 151);

        Einsatzimage.rectTransform.localPosition = new Vector3(Xrandom,Yrandom,0);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
