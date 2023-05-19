using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Image MenuImage;
    public Image LeitstellenImage;
    public Image StartImage;
    public Image Image;
    public Image ImageFederkreuz1;
    public Image ImageFederkreuz2;
    public Image OptionImage;
    public Image OptionHelpImage;
    public Image GameInfo;
    public Image MenuImageNormal;
    public Image MenuImageLeave;
    public Image GameStartAuswahlImage;
    public Image NewRangImage;
    public Image Logo;
    public Button CamButton;

    public Image AnruferImageExample;

    public Text GeschlechtsText;

    public Camera MenuCamera; 
    public Camera PlayerCamera;

    void Start()
    {
        AnruferImageExample.gameObject.SetActive(false);
        StartImage.gameObject.SetActive(true);
        MenuImage.gameObject.SetActive(false);
        LeitstellenImage.gameObject.SetActive(false);
        Image.gameObject.SetActive(false);
        ImageFederkreuz1.gameObject.SetActive(false);
        ImageFederkreuz2.gameObject.SetActive(false);
        OptionImage.gameObject.SetActive(false);
        GameInfo.gameObject.SetActive(false);
        MenuImageLeave.gameObject.SetActive(false);
        GameStartAuswahlImage.gameObject.SetActive(false);
        CamButton.gameObject.SetActive(true);
        MenuCamera.enabled = true;
        PlayerCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)&& NewRangImage.gameObject.activeSelf == false && Logo.gameObject.activeSelf == false && MenuImageLeave.gameObject.activeSelf == false && OptionImage.gameObject.activeSelf == false && StartImage.gameObject.activeSelf == false && LeitstellenImage.gameObject.activeSelf == false)
        {
            MenuImage.gameObject.SetActive(!MenuImage.gameObject.activeSelf);
            ImageFederkreuz1.gameObject.SetActive(!ImageFederkreuz1.gameObject.activeSelf);
            ImageFederkreuz2.gameObject.SetActive(!ImageFederkreuz2.gameObject.activeSelf);
            GameInfo.gameObject.SetActive(!GameInfo.gameObject.activeSelf);
            if (MenuImage.gameObject.activeSelf == true)
            {
                Cursor.lockState = CursorLockMode.Confined;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && LeitstellenImage.gameObject.activeSelf == true && Logo.gameObject.activeSelf == false)
        {
            Cursor.lockState = CursorLockMode.Locked;
            LeitstellenImage.gameObject.SetActive(false);
            MenuCamera.enabled = false;
            PlayerCamera.enabled = true;
            ImageFederkreuz1.gameObject.SetActive(!ImageFederkreuz1.gameObject.activeSelf);
            ImageFederkreuz2.gameObject.SetActive(!ImageFederkreuz2.gameObject.activeSelf);
            GameInfo.gameObject.SetActive(!GameInfo.gameObject.activeSelf);
            StartImage.gameObject.SetActive(false);
            MenuImage.gameObject.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && MenuImageLeave.gameObject.activeSelf == true && Logo.gameObject.activeSelf == false)
        {
            NoButtonclick();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && OptionImage.gameObject.activeSelf == true && Logo.gameObject.activeSelf == false)
        {
            if(OptionHelpImage.gameObject.activeSelf == true)
            {
                OptionImage.gameObject.SetActive(false);
                StartImage.gameObject.SetActive(true);
                OptionHelpImage.gameObject.SetActive(false);

            }
            else
            {
                OptionImage.gameObject.SetActive(false);
                MenuImage.gameObject.SetActive(true);
            }
        }
    }
    //Option
    public void OptionopenStartMenue()
    {
        OptionImage.gameObject.SetActive(true);
        OptionHelpImage.gameObject.SetActive(true);
        StartImage.gameObject.SetActive(false);
    }
    public void OptionopenMenue()
    {
        OptionImage.gameObject.SetActive(true);
        MenuImage.gameObject.SetActive(false);
    }
    public void OptionClose()
    {
        if (OptionHelpImage.gameObject.activeSelf == true)
        {
            StartImage.gameObject.SetActive(true);
            OptionHelpImage.gameObject.SetActive(false);
        }
        else
        {
            MenuImage.gameObject.SetActive(true);
        }
        OptionImage.gameObject.SetActive(false);
    }
    //Menu
    public void Cancelgame()
    {
        Application.Quit();
    }
    public void StartGame()
    {
        if(PlayerPrefs.GetString("StartAuswahl") == "true")
        {
            MenuCamera.enabled = false;
            PlayerCamera.enabled = true;
            ImageFederkreuz1.gameObject.SetActive(!ImageFederkreuz1.gameObject.activeSelf);
            ImageFederkreuz2.gameObject.SetActive(!ImageFederkreuz2.gameObject.activeSelf);
            GameInfo.gameObject.SetActive(!GameInfo.gameObject.activeSelf);
            StartImage.gameObject.SetActive(false);
            MenuImage.gameObject.SetActive(false);
            CamButton.gameObject.SetActive(false);
            if (StartImage.gameObject.activeSelf == true)
            {
                Cursor.lockState = CursorLockMode.Confined;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
            }
            GameStartAuswahlImage.gameObject.SetActive(false);
        }
        else
        {
            GameStartAuswahlImage.gameObject.SetActive(true);
            StartImage.gameObject.SetActive(false);
            GeschlechtsText.text = "männlich";
        }
    }
    public void newGame()
    {
        StartImage.gameObject.SetActive(false);
        GeschlechtsText.text = "männlich";
        GameStartAuswahlImage.gameObject.SetActive(true);
    }
    public void ContinueGame()
    {
        MenuImage.gameObject.SetActive(false);
        ImageFederkreuz1.gameObject.SetActive(!ImageFederkreuz1.gameObject.activeSelf);
        ImageFederkreuz2.gameObject.SetActive(!ImageFederkreuz2.gameObject.activeSelf);
        if (MenuImage.gameObject.activeSelf == true)
        {
            Cursor.lockState = CursorLockMode.Confined;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
    public void StartMenuClick()
    {
        StartImage.gameObject.SetActive(true);
        MenuImage.gameObject.SetActive(false);
        MenuImageNormal.gameObject.SetActive(true);
        MenuImageLeave.gameObject.SetActive(false);
        MenuCamera.enabled = true;
        PlayerCamera.enabled = false;

    }
    public void GameLeave()
    {
        MenuImageLeave.gameObject.SetActive(true);
        MenuImageNormal.gameObject.SetActive(false);
    }
    public void NoButtonclick()
    {
        MenuImageLeave.gameObject.SetActive(false);
        MenuImageNormal.gameObject.SetActive(true);
    }
}
