using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CamScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Image StartImage;
    public Image StartImageAuswahl;
    public Image Logo;
    public Button CamButton;
    private void Start()
    {
        Logo.gameObject.SetActive(false);
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && Logo.gameObject.activeSelf == true)
        {
            Logo.gameObject.SetActive(false);
            StartImage.gameObject.SetActive(true);
            CamButton.gameObject.SetActive(true);
        }
    }
    public void click()
    {
        StartImage.gameObject.SetActive(false);
        Logo.gameObject.SetActive(true);
        CamButton.gameObject.SetActive(false);
    }
}
