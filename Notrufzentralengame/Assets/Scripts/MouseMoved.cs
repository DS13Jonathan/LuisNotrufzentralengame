using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MouseMoved : MonoBehaviour
{
    public Color initialColor;
    public Color mouseOverColor;
    public bool mouseOver = false;
    public Image PressEText;

    public Image LeitsellenImage;
    // Start is called before the first frame update

    void Start()
    {
        LeitsellenImage.gameObject.SetActive(false);
        GetComponent<Renderer>().material.SetColor("_Color", initialColor);
        PressEText.gameObject.SetActive(false);
    }


    void OnMouseEnter()
    {
        mouseOver = true;
        GetComponent<Renderer>().material.SetColor("_Color", mouseOverColor);
        PressEText.gameObject.SetActive(true);
    }
    void OnMouseExit()
    {
        mouseOver = false;
        GetComponent<Renderer>().material.SetColor("_Color", initialColor);
        PressEText.gameObject.SetActive(false);
    }
    void OnMouseDown()
    {
        LeitsellenImage.gameObject.SetActive(true);
        PressEText.gameObject.SetActive(false);
    }
}
