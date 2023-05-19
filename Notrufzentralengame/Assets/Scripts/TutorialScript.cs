using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialScript : MonoBehaviour
{
    public Image TutorialImage;
    public Image StartImage;
    public Image StartImageAuswahl;
    public Camera MenuCamera;
    public Camera PlayerCamera;
    public Image ImageFederkreuz1;
    public Image ImageFederkreuz2;
    public Image GameInfo;
    public Image LogoImage;
    public Image FirstDoorImagechecker;
    public Image TutorialfirstImage;
    public GameObject TutorialObject;

    public Button CamButton;

    public Text nowText;
    public Text NextText;
    public Text nextnextText;

    public GameObject Player;
    public GameObject Makierer1;
    public GameObject Makierer2;
    public GameObject Makierer3;
    // Start is called before the first frame update
    void Start()
    {
        TutorialObject.gameObject.SetActive(false);
        FirstDoorImagechecker.gameObject.SetActive(false);
        TutorialImage.gameObject.SetActive(false);
        Makierer1.gameObject.SetActive(false);
        Makierer2.gameObject.SetActive(false);
        Makierer3.gameObject.SetActive(false);
        TutorialfirstImage.gameObject.SetActive(false);
        StartImageAuswahl.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(FirstDoorImagechecker.gameObject.activeSelf == true)
        {
            Makierer3.gameObject.SetActive(true);
            nowText.text = "Gehe zu dem makierten Tisch";
            NextText.text = " öffne den PC";
            nextnextText.text = "";
            FirstDoorImagechecker.gameObject.SetActive(false);

        }
        if(TutorialImage.gameObject.activeSelf == true && Makierer1.gameObject.activeSelf == true)
        {
            if((Makierer1.transform.position - Player.transform.position).magnitude <= 9)
            {
                Makierer1.gameObject.SetActive(false);
            }
        }
        if (TutorialImage.gameObject.activeSelf == true && Makierer2.gameObject.activeSelf == true)
        {
            if ((Makierer2.transform.position - Player.transform.position).magnitude <= 9)
            {
                Makierer2.gameObject.SetActive(false);
                nowText.text = "öffne die Türe";
                NextText.text = " Gehe zu dem makierten Tisch";
                nextnextText.text = " öffne den PC";
            }
        }
        if (TutorialImage.gameObject.activeSelf == true && Makierer3.gameObject.activeSelf == true)
        {
            if ((Makierer3.transform.position - Player.transform.position).magnitude <= 9)
            {
                Makierer3.gameObject.SetActive(false);
                nowText.text = "öffne den PC";
                NextText.text = "";
                nextnextText.text = "";
            }
        }
    }
    public void click()
    {
        TutorialObject.gameObject.SetActive(true);
        TutorialImage.gameObject.SetActive(true);
        CamButton.gameObject.SetActive(false);
        TutorialfirstImage.gameObject.SetActive(true);
        Makierer1.gameObject.SetActive(true);
        Makierer2.gameObject.SetActive(true);
        StartImage.gameObject.SetActive(false);
        StartImageAuswahl.gameObject.SetActive(false);
        LogoImage.gameObject.SetActive(false);
        GameInfo.gameObject.SetActive(false);
        nowText.text = "Lies den Text";
        NextText.text = " Gehe zur Türe";
        nextnextText.text = " öffne die Türe";
        MenuCamera.enabled = false;
        PlayerCamera.enabled = true;
    }
    public void clickStarttextButton()
    {
        if (StartImageAuswahl.gameObject.activeSelf == true)
        {
            Cursor.lockState = CursorLockMode.Confined;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        TutorialfirstImage.gameObject.SetActive(false);
        ImageFederkreuz1.gameObject.SetActive(!ImageFederkreuz1.gameObject.activeSelf);
        ImageFederkreuz2.gameObject.SetActive(!ImageFederkreuz2.gameObject.activeSelf);
        nowText.text = "Gehe zur Türe";
        NextText.text = " öffne die Türe";
        nextnextText.text = " Gehe zu dem makierten Tisch";
    }
}
