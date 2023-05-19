using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClsoeScript : MonoBehaviour
{
    public Image ButtonImage;
    public Image FahrzeugartImage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void click()
    {
        FahrzeugartImage.gameObject.SetActive(false);
        ButtonImage.gameObject.SetActive(true);
    }
}
