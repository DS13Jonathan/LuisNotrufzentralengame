using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rang : MonoBehaviour
{
    public string Rangstring;
    public int LevelInt;
    public int MaxLevelInt;

    public string Namecheck;
    public string Ortcheck;
    public string Straßencheck;
    public string Hausnummercheck;
    public string Einsatzstichwortcheck;

    public Text LevelText;
    public Text RangText;
    public Text LTLevelText;
    public Text LTRangText;

    public InputField EinsatzstichwortInputField;
    public InputField NameInputField;
    public InputField StraßetInputField;
    public InputField OrtInputField;
    public InputField RückrufnummertInputField;

    public Button FW1;
    public Button FW11;
    public Button FW12;
    public Button FW13;
    public Button FW14;
    public Button FW2;
    public Button FW3;
    public Button FW31;
    public Button FW4;
    public Image NewRangImage;
    public Image LeitstellenImage;
    public Text NewRangText;
    public Text EinsatzstichwortWert;
    public Text Einsatzstichwort;

    public Text GeschlechtsText;

    public Image NextRang;
    public string StartAuswahl;
    // Start is called before the first frame update
    void Start()
    {
        
        if (!PlayerPrefs.HasKey("Rang"))
        {
            PlayerPrefs.SetString("Rang", "Anwärter*in");
            StartAuswahl = "false";
        }
        if (!PlayerPrefs.HasKey("LevelInt"))
        {
            PlayerPrefs.SetInt("LevelInt", 0);
        }
        if (!PlayerPrefs.HasKey("MaxLevelInt"))
        {
            PlayerPrefs.SetInt("MaxLevelInt", 50);
        }
        Rangstring = PlayerPrefs.GetString("Rang");
        LevelInt = PlayerPrefs.GetInt("LevelInt");
        MaxLevelInt = PlayerPrefs.GetInt("MaxLevelInt");
        RangText.text = Rangstring;
        LevelText.text = LevelInt + "/" + MaxLevelInt;
        RangCheck();
        NextRang.gameObject.SetActive(false);
        LTRangText.text = RangText.text;
        LTLevelText.text = LevelText.text;
        StartAuswahl = PlayerPrefs.GetString("StartAuswahl");
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetString("Rang", Rangstring);
        PlayerPrefs.SetInt("LevelInt", LevelInt);
        PlayerPrefs.SetInt("MaxLevelInt", MaxLevelInt);
        PlayerPrefs.SetString("StartAuswahl", StartAuswahl);

        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void RangCheck() {
        if(Rangstring == "Anwärter*in")
        {
            ResetFWButton();
            FW4.gameObject.SetActive(true);
        }
        if (Rangstring == "Feuerwehrmann" || Rangstring == "Feuerwehrfrau")
        {
            ResetFWButton();
            FW4.gameObject.SetActive(true);
            FW11.gameObject.SetActive(true);
        }
        if (Rangstring == "Oberfeuerwehrmann" || Rangstring == "Oberfeuerwehrfrau")
        {
            ResetFWButton();
            FW4.gameObject.SetActive(true);
            FW11.gameObject.SetActive(true);
            FW3.gameObject.SetActive(true);
        }
        if (Rangstring == "Hauptfeuerwehrmann" || Rangstring == "Hauptfeuerwehrfrau")
        {
            ResetFWButton();
            FW4.gameObject.SetActive(true);
            FW11.gameObject.SetActive(true);
            FW3.gameObject.SetActive(true);
            FW12.gameObject.SetActive(true);
        }
        if (Rangstring == "Unterbrandmeister" || Rangstring == "Unterbrandmeisterin")
        {
            ResetFWButton();
            FW4.gameObject.SetActive(true);
            FW11.gameObject.SetActive(true);
            FW3.gameObject.SetActive(true);
            FW12.gameObject.SetActive(true);
            FW2.gameObject.SetActive(true);
        }
        if (Rangstring == "Brandmeister" || Rangstring == "Brandmeisterin")
        {
            ResetFWButton();
            FW4.gameObject.SetActive(true);
            FW11.gameObject.SetActive(true);
            FW3.gameObject.SetActive(true);
            FW12.gameObject.SetActive(true);
            FW2.gameObject.SetActive(true);
            FW31.gameObject.SetActive(true);
        }
        if (Rangstring == "Oberbrandmeister" || Rangstring == "Oberbrandmeisterin")
        {
            ResetFWButton();
            FW4.gameObject.SetActive(true);
            FW11.gameObject.SetActive(true);
            FW3.gameObject.SetActive(true);
            FW12.gameObject.SetActive(true);
            FW2.gameObject.SetActive(true);
            FW31.gameObject.SetActive(true);
            FW13.gameObject.SetActive(true);
        }
        if (Rangstring == "Hauptbrandmeister" || Rangstring == "Hauptbrandmeisterin")
        {
            ResetFWButton();
            FW4.gameObject.SetActive(true);
            FW11.gameObject.SetActive(true);
            FW3.gameObject.SetActive(true);
            FW12.gameObject.SetActive(true);
            FW2.gameObject.SetActive(true);
            FW31.gameObject.SetActive(true);
            FW13.gameObject.SetActive(true);
            FW14.gameObject.SetActive(true);
        }
        if (Rangstring == "Brandinspektor" || Rangstring == "Brandinspektorin")
        {
            ResetFWButton();
            FW4.gameObject.SetActive(true);
            FW11.gameObject.SetActive(true);
            FW3.gameObject.SetActive(true);
            FW12.gameObject.SetActive(true);
            FW2.gameObject.SetActive(true);
            FW31.gameObject.SetActive(true);
            FW13.gameObject.SetActive(true);
            FW14.gameObject.SetActive(true);
            FW1.gameObject.SetActive(true);
        }
        if (Rangstring == "Stadtinspektor" || Rangstring == "Stadtinspektorin")
        {
            ResetFWButton();
            FW4.gameObject.SetActive(true);
            FW11.gameObject.SetActive(true);
            FW3.gameObject.SetActive(true);
            FW12.gameObject.SetActive(true);
            FW2.gameObject.SetActive(true);
            FW31.gameObject.SetActive(true);
            FW13.gameObject.SetActive(true);
            FW14.gameObject.SetActive(true);
            FW1.gameObject.SetActive(true);
        }
    }
    public void ResetFWButton()
    {
        FW1.gameObject.SetActive(false);
        FW11.gameObject.SetActive(false);
        FW12.gameObject.SetActive(false);
        FW13.gameObject.SetActive(false);
        FW14.gameObject.SetActive(false);
        FW2.gameObject.SetActive(false);
        FW3.gameObject.SetActive(false);
        FW31.gameObject.SetActive(false);
        FW4.gameObject.SetActive(false);
    }
    public void CheckLevel()
    {
        if (Rangstring == "Stadtinspektor" || Rangstring == "Stadtinspektorin")
        {
            if (LevelInt >= 4000)
            {
                Rangstring = "Ende";
                LevelInt = 0;
                //
                MaxLevelInt = 0;
                LevelText.text = LevelInt + "/" + MaxLevelInt;
                //
                RangText.text = Rangstring;

                RangCheck();
                StartCoroutine(NewRangAnimation());
            }
        }

        if (Rangstring == "Brandinspektor" || Rangstring == "Brandinspektorin")
        {
            if(LevelInt >= 3000)
            {
                if (GeschlechtsText.text == "weiblich")
                {
                    Rangstring = "Stadtinspektorin";
                }
                else
                {
                    Rangstring = "Stadtinspektor";
                }
                LevelInt = 0;
                //
                MaxLevelInt = 4000;
                LevelText.text = LevelInt + "/" + MaxLevelInt;
                //
                RangText.text = Rangstring;

                RangCheck();
                StartCoroutine(NewRangAnimation());
            }
        }

        if (Rangstring == "Hauptbrandmeister" || Rangstring == "Hauptbrandmeisterin")
        {
            if (LevelInt >= 1750)
            {
                if (GeschlechtsText.text == "weiblich")
                {
                    Rangstring = "Brandinspektorin";
                }
                else
                {
                    Rangstring = "Brandinspektor";
                }
                LevelInt = 0;
                //
                MaxLevelInt = 3000;
                LevelText.text = LevelInt + "/" + MaxLevelInt;
                //
                RangText.text = Rangstring;

                RangCheck();
                StartCoroutine(NewRangAnimation());
            }
        }

        if (Rangstring == "Oberbrandmeister" || Rangstring == "Oberbrandmeisterin")
        {
            if (LevelInt >= 1500)
            {
                if (GeschlechtsText.text == "weiblich")
                {
                    Rangstring = "Hauptbrandmeisterin";
                }
                else
                {
                    Rangstring = "Hauptbrandmeister";
                }
                LevelInt = 0;
                //
                MaxLevelInt = 1750;
                LevelText.text = LevelInt + "/" + MaxLevelInt;
                //
                RangText.text = Rangstring;

                RangCheck();
                StartCoroutine(NewRangAnimation());
            }
        }

            if (Rangstring == "Brandmeister" || Rangstring == "Brandmeisterin")
        {
            if (LevelInt >= 7500)
            {
                if (GeschlechtsText.text == "weiblich")
                {
                    Rangstring = "Oberbrandmeisterin";
                }
                else
                {
                    Rangstring = "Oberbrandmeister";
                }
                LevelInt = 0;
                //
                MaxLevelInt = 1500;
                LevelText.text = LevelInt + "/" + MaxLevelInt;
                //
                RangText.text = Rangstring;

                RangCheck();
                StartCoroutine(NewRangAnimation());
            }
        }

        if (Rangstring == "Unterbrandmeister" || Rangstring == "Unterbrandmeisterin")
        {
            if (LevelInt >= 500)
            {
                if (GeschlechtsText.text == "weiblich")
                {
                    Rangstring = "Brandmeisterin";
                }
                else
                {
                    Rangstring = "Brandmeister";
                }
                LevelInt = 0;
                //
                MaxLevelInt = 750;
                LevelText.text = LevelInt + "/" + MaxLevelInt;
                //
                RangText.text = Rangstring;

                RangCheck();
                StartCoroutine(NewRangAnimation());
            }
        }

        if (Rangstring == "Hauptfeuerwehrmann" || Rangstring == "Hauptfeuerwehrfrau")
        {
            if (LevelInt >= 400)
            {
                if (GeschlechtsText.text == "weiblich")
                {
                    Rangstring = "Unterbrandmeisterin";
                }
                else
                {
                    Rangstring = "Unterbrandmeister";
                }
                LevelInt = 0;
                //
                MaxLevelInt = 500;
                LevelText.text = LevelInt + "/" + MaxLevelInt;
                //
                RangText.text = Rangstring;

                RangCheck();
                StartCoroutine(NewRangAnimation());
            }
        }

        if (Rangstring == "Oberfeuerwehrmann" || Rangstring == "Oberfeuerwehrfrau")
        {
            if (LevelInt >= 500)
            {
                if (GeschlechtsText.text == "weiblich")
                {
                    Rangstring = "Hauptfeuerwehrfrau";
                }
                else
                {
                    Rangstring = "Hauptfeuerwehrmann";
                }
                LevelInt = 0;
                //
                MaxLevelInt = 400;
                LevelText.text = LevelInt + "/" + MaxLevelInt;
                //
                RangText.text = Rangstring;

                RangCheck();
                StartCoroutine(NewRangAnimation());
            }
        }

        if (Rangstring == "Feuerwehrmann" || Rangstring == "Feuerwehrfrau" )
        {
            if (LevelInt >= 100)
            {
                if (GeschlechtsText.text == "weiblich")
                {
                    Rangstring = "Oberfeuerwehrfrau";
                }
                else
                {
                    Rangstring = "Oberfeuerwehrmann";
                }
                LevelInt = 0;
                //
                MaxLevelInt = 250;
                LevelText.text = LevelInt + "/" + MaxLevelInt;
                //
                RangText.text = Rangstring;

                RangCheck();
                StartCoroutine(NewRangAnimation());
            }
        }

        if (Rangstring == "Anwärter*in")
        {
            if (LevelInt >= 50)
            {
                if (GeschlechtsText.text == "weiblich")
                {
                    Rangstring = "Feuerwehrfrau";
                }
                else
                {
                    Rangstring = "Feuerwehrmann";
                }
                LevelInt = 0;
                //
                MaxLevelInt = 100;
                LevelText.text = LevelInt + "/" + MaxLevelInt;
                //
                RangText.text = Rangstring;

                RangCheck();
                StartCoroutine(NewRangAnimation());
            }
        }
        LevelText.text = LevelInt + "/" + MaxLevelInt;
        LTRangText.text = RangText.text;
        LTLevelText.text = LevelText.text;
        EinsatzstichwortWert.text = "";
        Einsatzstichwort.text = "";

    }
    public void click() {
        if (EinsatzstichwortInputField.text == "" || NameInputField.text == "" || RückrufnummertInputField.text == "" || OrtInputField.text == "" || StraßetInputField.text == "")
        {

        }
        else
        {
            if (EinsatzstichwortWert.text == "1")
            {
                LevelInt = LevelInt + 1;
            }
            if (EinsatzstichwortWert.text == "5")
            {
                LevelInt = LevelInt + 5;
            }
            if (EinsatzstichwortWert.text == "10")
            {
                LevelInt = LevelInt + 10;
            }
            if (EinsatzstichwortWert.text == "20")
            {
                LevelInt = LevelInt + 20;
            }
            if (EinsatzstichwortWert.text == "30")
            {
                LevelInt = LevelInt + 30;
            }
            if (EinsatzstichwortWert.text == "50")
            {
                LevelInt = LevelInt + 50;
            }
            CheckLevel();
            LTRangText.text = RangText.text;
            LTLevelText.text = LevelText.text;
            EinsatzstichwortWert.text = "";
            Einsatzstichwort.text = "";
        }
    }
    public void Fastclick10()
    {
        LevelInt = LevelInt + 10;
        CheckLevel();
        LTRangText.text = RangText.text;
        LTLevelText.text = LevelText.text;
    }
    public void Fastclick100()
    {
        LevelInt = LevelInt + 100;
        CheckLevel();
        LTRangText.text = RangText.text;
        LTLevelText.text = LevelText.text;
    }
    public void ResetClick()
    {
        Rangstring = "Anwärter*in";
        LevelInt = 0;
        MaxLevelInt = 50;
        LevelText.text = LevelInt + "/" + MaxLevelInt;
        RangText.text = Rangstring;
        LTRangText.text = RangText.text;
        LTLevelText.text = LevelText.text;
        StartAuswahl = "false";
        PlayerPrefs.SetString("StartAuswahl", "false");
        RangCheck();

    }
    public void clickStartAuswahl()
    {
        StartAuswahl = "true";
        PlayerPrefs.SetString("StartAuswahl", "true");
    }
    IEnumerator NewRangAnimation()
    {
        NewRangText.text = "Du bist jetzt " + Rangstring;
        NewRangImage.gameObject.SetActive(!NewRangImage.gameObject.activeSelf);
        LeitstellenImage.gameObject.SetActive(false);
        yield return new WaitForSeconds(2);
        NewRangImage.gameObject.SetActive(!NewRangImage.gameObject.activeSelf);
        LeitstellenImage.gameObject.SetActive(true);
    }

}
