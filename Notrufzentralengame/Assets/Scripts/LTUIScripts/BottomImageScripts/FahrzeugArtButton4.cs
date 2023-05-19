using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FahrzeugArtButton4 : MonoBehaviour
{
    public Image FahrzeugeImage;
    public Image ButtonImage;
    public Image LFImage;
    public Image MTFImage;

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

        ImageImage.gameObject.SetActive(true);
    }
}
