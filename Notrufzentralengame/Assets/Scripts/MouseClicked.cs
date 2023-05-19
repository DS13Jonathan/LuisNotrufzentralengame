
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;



public class MouseClicked : MonoBehaviour
{
    public Color initialColor;
    public Color mouseOverColor;
    public bool mouseOver = false;

    public GameObject Player;

    public Image Fadenkreuz1;
    public Image Fadenkreuz2;
    public Text PressEText;
    public Image StartImage;
    public Image MenuImage;
    public Image GameInfo;
    public Image NewRangImage;

    public GameObject Table;

    public Image LeitsellenImage;
    // Start is called before the first frame update

    void Start()
    {
        LeitsellenImage.gameObject.SetActive(false);
        PressEText.gameObject.SetActive(false);
        GetComponent<Renderer>().material.SetColor("_Color", initialColor);
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E) && mouseOver == true)
        {
            PressEText.gameObject.SetActive(false);
            Fadenkreuz1.gameObject.SetActive(false);
            Fadenkreuz2.gameObject.SetActive(false);

            GameInfo.gameObject.SetActive(false);
            LeitsellenImage.gameObject.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
        }
    }

    void OnMouseEnter()
    {
       if (NewRangImage.gameObject.activeSelf == false && LeitsellenImage.gameObject.activeSelf == false && StartImage.gameObject.activeSelf == false && MenuImage.gameObject.activeSelf == false && (Table.transform.position - Player.transform.position).magnitude <= 9)
       {
            mouseOver = true;
            GetComponent<Renderer>().material.SetColor("_Color", mouseOverColor);
            PressEText.gameObject.SetActive(true);
       }
    }
    void OnMouseExit()
    {
        mouseOver = false;
        GetComponent<Renderer>().material.SetColor("_Color", initialColor);
        PressEText.gameObject.SetActive(false);
    }
}
