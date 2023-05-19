using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WachenButtonClick : MonoBehaviour
{
    public Image FahrezugImage1;
    public Image FahrezugImage11;
    public Image FahrezugImage12;
    public Image FahrezugImage13;
    public Image FahrezugImage14;
    public Image FahrezugImage2;
    public Image FahrezugImage3;
    public Image FahrezugImage31;
    public Image FahrezugImage4;

    public Image MainFahrzeugImage;
    // Start is called before the first frame update
    void Start()
    {
        FahrezugImage1.gameObject.SetActive(false);
        FahrezugImage11.gameObject.SetActive(false);
        FahrezugImage12.gameObject.SetActive(false);
        FahrezugImage13.gameObject.SetActive(false);
        FahrezugImage14.gameObject.SetActive(false);
        FahrezugImage2.gameObject.SetActive(false);
        FahrezugImage3.gameObject.SetActive(false);
        FahrezugImage31.gameObject.SetActive(false);
        FahrezugImage4.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Click()
    {
        FahrezugImage1.gameObject.SetActive(false);
        FahrezugImage11.gameObject.SetActive(false);
        FahrezugImage12.gameObject.SetActive(false);
        FahrezugImage13.gameObject.SetActive(false);
        FahrezugImage14.gameObject.SetActive(false);
        FahrezugImage2.gameObject.SetActive(false);
        FahrezugImage3.gameObject.SetActive(false);
        FahrezugImage31.gameObject.SetActive(false);
        FahrezugImage4.gameObject.SetActive(false);

        MainFahrzeugImage.gameObject.SetActive(true);
    }
}
