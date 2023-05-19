using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPressScriptRD : MonoBehaviour
{
    public Image ButtonImageDü;
    public Image ButtonImageVie;
    // Start is called before the first frame update
    void Start()
    {
        ResetButton();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetButton()
    {
        ButtonImageDü.gameObject.SetActive(false);
        ButtonImageVie.gameObject.SetActive(false);
    }
    public void ButtonVie()
    {
        ResetButton();
        ButtonImageVie.gameObject.SetActive(true);
    }
    public void ButtonDü()
    {
        ResetButton();
        ButtonImageDü.gameObject.SetActive(true);
    }
}
