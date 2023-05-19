using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;



public class MouseClickedDoor : MonoBehaviour
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

    public Image TurtorialfirstDoorImage;
    public Image TutorialImage;

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
            Ture.transform.position = new Vector3(22, 2, -10.75f);
            if (TutorialImage.gameObject.activeSelf == true)
            {
                Debug.Log("Test2");
                TurtorialfirstDoorImage.gameObject.SetActive(true);
            }
        }
        if (mouseOver == true && LeitsellenImage.gameObject.activeSelf == false && StartImage.gameObject.activeSelf == false && MenuImage.gameObject.activeSelf == false && (Table.transform.position - Player.transform.position).magnitude <= 9)
        {
            PressEText.gameObject.SetActive(true);
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
