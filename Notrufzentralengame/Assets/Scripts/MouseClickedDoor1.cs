using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;



public class MouseClickedDoor1 : MonoBehaviour
{
    public Color initialColor;
    public Color mouseOverColor;
    public bool mouseOver = false;

    public GameObject Ture;

    public GameObject Player;

    public Image Fadenkreuz1;
    public Image Fadenkreuz2;
    public Text PressEText;
    public Image StartImage;
    public Image MenuImage;

    public Image TutorialImage;

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
        if(TutorialImage.gameObject.activeSelf == false)
        {
            if (Input.GetKeyUp(KeyCode.E) && mouseOver == true)
            {
                Ture.transform.position = new Vector3(22, 2, -10.75f);
                if (TutorialImage.gameObject.activeSelf == true)
                {
                    Debug.Log("Test2");
                }
            }
            if (mouseOver == true && LeitsellenImage.gameObject.activeSelf == false && StartImage.gameObject.activeSelf == false && MenuImage.gameObject.activeSelf == false && (Ture.transform.position - Player.transform.position).magnitude <= 9)
            {
                PressEText.gameObject.SetActive(true);
            }
        }
    }

    void OnMouseEnter()
    {
        mouseOver = true;
    }
    void OnMouseExit()
    {
        mouseOver = false;
        PressEText.gameObject.SetActive(false);
    }
}
