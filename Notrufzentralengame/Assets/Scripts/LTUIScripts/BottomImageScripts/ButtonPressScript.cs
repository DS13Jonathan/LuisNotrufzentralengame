using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPressScript : MonoBehaviour
{
    public Image ButtonImage1;
    public Image ButtonImage2;
    public Image ButtonImage3;
    public Image ButtonImage4;
    public Image ButtonImage5;
    public Image ButtonImage6;
    public Image ButtonImage7;
    public Image ButtonImage8;
    public Image ButtonImage9;
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
        ButtonImage1.gameObject.SetActive(false);
        ButtonImage2.gameObject.SetActive(false);
        ButtonImage3.gameObject.SetActive(false);
        ButtonImage4.gameObject.SetActive(false);
        ButtonImage5.gameObject.SetActive(false);
        ButtonImage6.gameObject.SetActive(false);
        ButtonImage7.gameObject.SetActive(false);
        ButtonImage8.gameObject.SetActive(false);
        ButtonImage9.gameObject.SetActive(false);
    }
    public void Button1()
    {
        ResetButton();
        ButtonImage1.gameObject.SetActive(true);
    }
    public void Button2()
    {
        ResetButton();
        ButtonImage2.gameObject.SetActive(true);
    }
    public void Button3()
    {
        ResetButton();
        ButtonImage3.gameObject.SetActive(true);
    }
    public void Button4()
    {
        ResetButton();
        ButtonImage4.gameObject.SetActive(true);
    }
    public void Button5()
    {
        ResetButton();
        ButtonImage5.gameObject.SetActive(true);
    }
    public void Button6()
    {
        ResetButton();
        ButtonImage6.gameObject.SetActive(true);
    }
    public void Button7()
    {
        ResetButton();
        ButtonImage7.gameObject.SetActive(true);
    }
    public void Button8()
    {
        ResetButton();
        ButtonImage8.gameObject.SetActive(true);
    }
    public void Button9()
    {
        ResetButton();
        ButtonImage9.gameObject.SetActive(true);
    }
}
