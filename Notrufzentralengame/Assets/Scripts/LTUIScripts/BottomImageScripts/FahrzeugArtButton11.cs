using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FahrzeugArtButton11 : MonoBehaviour
{
    public Image FahrzeugeImage;
    public Image ButtonImage;
    public Image CBRN_Erkunde;
    public Image LFImage;
    public Image GWImage;
    public Image MTFImage;
    public Image ELWImage;

    public Image ImageImage;

    void Start()
    {
        FahrzeugeImage.gameObject.SetActive(false);
        ButtonImage.gameObject.SetActive(true);
    }

    public void Buttonclick()
    {
        FahrzeugeImage.gameObject.SetActive(true);
        ButtonImage.gameObject.SetActive(false);

        LFImage.gameObject.SetActive(false);
        MTFImage.gameObject.SetActive(false);
        GWImage.gameObject.SetActive(false);
        ELWImage.gameObject.SetActive(false);
        CBRN_Erkunde.gameObject.SetActive(false);

        ImageImage.gameObject.SetActive(true);
    }
}
