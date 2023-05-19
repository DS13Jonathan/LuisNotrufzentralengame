using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LichtschalterClickoff : MonoBehaviour
{
    public Color initialColor;
    public Color mouseOverColor;
    public bool mouseOver = false;

    public GameObject Player;

    public GameObject Lichtschalteron;
    public GameObject Lichtschalteroff;

    public Text LightonText;
    public Text LightoffText;
    
    public Image StartImage;
    public Image MenuImage;

    public Light Light1;
    public Light Light2;
    public Light Light3;
    public Light Light4;
    public Light Light5;
    public Light Light6;
    public Light Light7;
    public Light Light8;
    public Light Light9;
    public Light Light10;
    public Light Light11;
    public Light Light12;

    // Start is called before the first frame update
    void Start()
    {
        LightonText.gameObject.SetActive(false);
        LightoffText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E) && mouseOver == true)
        {
            LightonText.gameObject.SetActive(false);
            LightoffText.gameObject.SetActive(true);
            Lichtschalteron.gameObject.SetActive(!Lichtschalteron.gameObject.activeSelf);
            Lichtschalteroff.gameObject.SetActive(!Lichtschalteroff.gameObject.activeSelf);

            Light1.intensity = 0.01f;
            Light2.intensity = 0.01f;
            Light3.intensity = 0.01f;
            Light4.intensity = 0.01f;
            Light5.intensity = 0.01f;
            Light6.intensity = 0.01f;
            Light7.intensity = 0.01f;
            Light8.intensity = 0.01f;
            Light9.intensity = 0.01f;
            Light10.intensity = 0.01f;
            Light11.intensity = 0.01f;
            Light12.intensity = 0.01f;
        }
    }
    void OnMouseOver()
    {
        if (StartImage.gameObject.activeSelf == false && MenuImage.gameObject.activeSelf == false && (Lichtschalteroff.transform.position - Player.transform.position).magnitude <= 8)
        {
            mouseOver = true;
            GetComponent<Renderer>().material.SetColor("_Color", mouseOverColor);
            LightonText.gameObject.SetActive(true);
        }
    }
    void OnMouseExit()
    {
        mouseOver = false;
        GetComponent<Renderer>().material.SetColor("_Color", initialColor);
        LightonText.gameObject.SetActive(false);
    }
}
