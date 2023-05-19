using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FahrzeugArtButton : MonoBehaviour
{
    public Image FahrzeugeImage;
    public Image ButtonImage;
    public Image LFImage;
    public Image KdowImage;
    public Image DLKImage;
    public Image GWImage;
    public Image WLFImage;
    public Image MTFImage;
    public Image VLFImage;
    public Image KEFImage;

    public Image ImageImage;
    public Image ImageWLF;
    public Image ImageAB;

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
        KdowImage.gameObject.SetActive(false);
        DLKImage.gameObject.SetActive(false);
        GWImage.gameObject.SetActive(false);
        MTFImage.gameObject.SetActive(false);
        WLFImage.gameObject.SetActive(false);
        VLFImage.gameObject.SetActive(false);
        KEFImage.gameObject.SetActive(false);

        ImageImage.gameObject.SetActive(true);
        ImageWLF.gameObject.SetActive(true);
        ImageAB.gameObject.SetActive(false);
    }
}
