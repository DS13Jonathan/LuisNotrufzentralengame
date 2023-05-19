using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LichtschalterClickon : MonoBehaviour
{
    public Color initialColor;
    public Color mouseOverColor;
    public bool mouseOver = false;

    public GameObject Player;

    public GameObject Lichtschalteron;
    public GameObject Lichtschalteroff;

    public Text LightoffText;
    public Text LightonText;

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
        Light1.intensity = 0f;
        Light2.intensity = 0f;
        Light3.intensity = 0f;
        Light4.intensity = 0f;
        Light5.intensity = 0f;
        Light6.intensity = 0f;
        Light7.intensity = 0f;
        Light8.intensity = 0f;
        Light9.intensity = 0f;
        Light10.intensity = 0f;
        Light11.intensity = 0f;
        Light12.intensity = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E) && mouseOver == true)
        {
            LightonText.gameObject.SetActive(true);
            LightoffText.gameObject.SetActive(false);
            Lichtschalteron.gameObject.SetActive(!Lichtschalteron.gameObject.activeSelf);
            Lichtschalteroff.gameObject.SetActive(!Lichtschalteroff.gameObject.activeSelf);

            Light1.intensity = 0f;
            Light2.intensity = 0f;
            Light3.intensity = 0f;
            Light4.intensity = 0f;
            Light5.intensity = 0f;
            Light6.intensity = 0f;
            Light7.intensity = 0f;
            Light8.intensity = 0f;
            Light9.intensity = 0f;
            Light10.intensity = 0f;
            Light11.intensity = 0f;
            Light12.intensity = 0f;
        }
    }
    void OnMouseOver()
    {
        if (StartImage.gameObject.activeSelf == false && MenuImage.gameObject.activeSelf == false && (Lichtschalteron.transform.position - Player.transform.position).magnitude <= 8)
        {
            mouseOver = true;
            GetComponent<Renderer>().material.SetColor("_Color", mouseOverColor);
            LightoffText.gameObject.SetActive(true);
        }
    }
    void OnMouseExit()
    {
        mouseOver = false;
        GetComponent<Renderer>().material.SetColor("_Color", initialColor);
        LightoffText.gameObject.SetActive(false);
    }
}
