using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EinsatzstichwortInputFieldScript : MonoBehaviour
{
    public InputField inputField;
    public Text InputFieldText;
    public Image Einsatsliste;
    public GameObject scrollViewContent;
    public Button AbischerungsButton;

    public Button B1;
    public Button B1P;
    public Button B2;
    public Button B2P;
    public Button B3;
    public Button B3P;
    public Button B4;
    public Button B5;
    public Button B6;
    public Button B7;
    public Button BABC;
    public Button BBMA;
    public Button BBeleuchtug;
    public Button BenzinausPKW;
    public Button Bombenfund;
    public Button BBoot;
    public Button BELEKTROANLANGE;
    public Button BSchienen;
    public Button Bexplosion;
    public Button BWald;
    public Button BZug;

    public Button Eisunfall1;
    public Button Eisunfall2;

    public Button Einsturz;

    public Button Inten1;
    public Button Inten2;
    public Button Inten3;
    public Button Inten4;

    public Button Krankentransport;

    public Button MANV2;
    public Button MANV1;

    public Button Notfallseelsorge;

    public Button Peingeklemmt;
    public Button PAufzug;
    public Button PRettungHöhenuTiefen;
    public Button PStrom;
    public Button PsychosozialeUnterstürzung;
    public Button Pverschüttet;

    public Button RD1;
    public Button RD1Neugeborendes;
    public Button RD2;
    public Button RD2Kind;
    public Button RD3;
    public Button RD4;
    public Button RD5;

    public Button Tauchunfall;
    public Button Tragehilfe;
    public Button THL1;
    public Button THL2;
    public Button THL3;
    public Button THL4;
    public Button THL5;
    public Button THLABC;

    public Button Unwetter;
    public Button VUFluzeug1;
    public Button VUFluzeug2;
    public Button VUZug;

    public Button Wassernot1;
    public Button Wassernot2;
    public Button Wassernot3;

    public Button Ölspur;
    public Button ÜberörtlicherEinsatz;
    // Start is called before the first frame update
    void Start()
    {
        inputField = GetComponent<InputField>();
        inputField.onValueChanged.AddListener(OnValueChanged);
        Einsatsliste.gameObject.SetActive(false);
    }
    private void OnValueChanged(string value)
    {
        inputField.text = value.ToUpper();
    }
    public void ResetButton()
    {
        AbischerungsButton.gameObject.SetActive(false);

        B1.gameObject.SetActive(false);
        B1P.gameObject.SetActive(false);
        B2.gameObject.SetActive(false);
        B2P.gameObject.SetActive(false);
        B3.gameObject.SetActive(false);
        B3P.gameObject.SetActive(false);
        B4.gameObject.SetActive(false);
        B5.gameObject.SetActive(false);
        B6.gameObject.SetActive(false);
        B7.gameObject.SetActive(false);
        BBMA.gameObject.SetActive(false);
        BABC.gameObject.SetActive(false);
        BBeleuchtug.gameObject.SetActive(false);
        BenzinausPKW.gameObject.SetActive(false);
        Bombenfund.gameObject.SetActive(false);
        BBoot.gameObject.SetActive(false);
        BELEKTROANLANGE.gameObject.SetActive(false);
        BSchienen.gameObject.SetActive(false);
        Bexplosion.gameObject.SetActive(false);
        BWald.gameObject.SetActive(false);
        BZug.gameObject.SetActive(false);

        Eisunfall1.gameObject.SetActive(false);
        Eisunfall2.gameObject.SetActive(false);

        Einsturz.gameObject.SetActive(false);

        Inten1.gameObject.SetActive(false);
        Inten2.gameObject.SetActive(false);
        Inten3.gameObject.SetActive(false);
        Inten4.gameObject.SetActive(false);

        Krankentransport.gameObject.SetActive(false);

        MANV1.gameObject.SetActive(false);
        MANV2.gameObject.SetActive(false);

        Notfallseelsorge.gameObject.SetActive(false);

        Peingeklemmt.gameObject.SetActive(false);
        PAufzug.gameObject.SetActive(false);
        PRettungHöhenuTiefen.gameObject.SetActive(false);
        PStrom.gameObject.SetActive(false);
        PsychosozialeUnterstürzung.gameObject.SetActive(false);
        Pverschüttet.gameObject.SetActive(false);

        RD1.gameObject.SetActive(false);
        RD1Neugeborendes.gameObject.SetActive(false);
        RD2.gameObject.SetActive(false);
        RD2Kind.gameObject.SetActive(false);
        RD3.gameObject.SetActive(false);
        RD4.gameObject.SetActive(false);
        RD5.gameObject.SetActive(false);

        Tauchunfall.gameObject.SetActive(false);
        Tragehilfe.gameObject.SetActive(false);
        THL1.gameObject.SetActive(false);
        THL2.gameObject.SetActive(false);
        THL3.gameObject.SetActive(false);
        THL4.gameObject.SetActive(false);
        THL5.gameObject.SetActive(false);
        THLABC.gameObject.SetActive(false);

        Unwetter.gameObject.SetActive(false);
        VUFluzeug1.gameObject.SetActive(false);
        VUFluzeug2.gameObject.SetActive(false);
        VUZug.gameObject.SetActive(false);

        Wassernot1.gameObject.SetActive(false);
        Wassernot2.gameObject.SetActive(false);
        Wassernot3.gameObject.SetActive(false);

        Ölspur.gameObject.SetActive(false);
        ÜberörtlicherEinsatz.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        RectTransform contentRectTransform = scrollViewContent.GetComponent<RectTransform>();

        contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x,0);

        if (InputFieldText.text == "A"|| InputFieldText.text == "AB"|| InputFieldText.text == "ABS"|| InputFieldText.text == "ABSI" || InputFieldText.text == "ABSIC" || InputFieldText.text == "ABSICH" || InputFieldText.text == "ABSICHE" || InputFieldText.text == "ABSICHEE" || InputFieldText.text == "ABSICHERU" || InputFieldText.text == "ABSICHERUN" || InputFieldText.text == "ABSICHERUNG")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            AbischerungsButton.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "B" || InputFieldText.text == "B " || InputFieldText.text == "B1" || InputFieldText.text == "B 1")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);

            B1.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "B" || InputFieldText.text == "B " || InputFieldText.text == "B2" || InputFieldText.text == "B 2")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);

            B2.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "B" || InputFieldText.text == "B " || InputFieldText.text == "B1" || InputFieldText.text == "B 1" || InputFieldText.text == "B1P" || InputFieldText.text == "B 1 P" || InputFieldText.text == "B 1P")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);

            B1P.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "B" || InputFieldText.text == "B " || InputFieldText.text == "B3" || InputFieldText.text == "B 3")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);

            B3.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "B" || InputFieldText.text == "B " || InputFieldText.text == "B4" || InputFieldText.text == "B 4")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);

            B4.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "B" || InputFieldText.text == "B " || InputFieldText.text == "B5" || InputFieldText.text == "B 5")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);

            B5.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "B" || InputFieldText.text == "B " || InputFieldText.text == "B6" || InputFieldText.text == "B 6")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);

            B6.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "B" || InputFieldText.text == "B " || InputFieldText.text == "B7" || InputFieldText.text == "B 7")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);

            B7.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "B" || InputFieldText.text == "B " || InputFieldText.text == "B B" || InputFieldText.text == "B BM" || InputFieldText.text == "B BMA")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);

            BBMA.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "B" || InputFieldText.text == "BE" || InputFieldText.text == "BEL" || InputFieldText.text == "BELE" || InputFieldText.text == "BELEU" || InputFieldText.text == "BELEUC" || InputFieldText.text == "BELEUCH" || InputFieldText.text == "BELEUCHT" || InputFieldText.text == "BELEUCHTU" || InputFieldText.text == "BELEUCHTUN" || InputFieldText.text == "BELEUCHTUNG")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);

            BBeleuchtug.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "B")
        {
            int size = 32 * 10;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            B2P.gameObject.SetActive(true);
            B3P.gameObject.SetActive(true);
            BABC.gameObject.SetActive(true);
            BenzinausPKW.gameObject.SetActive(true);
            Bombenfund.gameObject.SetActive(true);
            BSchienen.gameObject.SetActive(true);
            Bexplosion.gameObject.SetActive(true);
            BWald.gameObject.SetActive(true);
            BZug.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "E"|| InputFieldText.text == "EI"|| InputFieldText.text == "EIS"|| InputFieldText.text == "EISU" || InputFieldText.text == "EISUN" || InputFieldText.text == "EISUNF" || InputFieldText.text == "EISUNFA" || InputFieldText.text == "EISUNFAL" || InputFieldText.text == "EISUNFALL" || InputFieldText.text == "EISUNFALL " || InputFieldText.text == "EISUNFALL 1") {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            Eisunfall1.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "E" || InputFieldText.text == "EI" || InputFieldText.text == "EIS" || InputFieldText.text == "EISU" || InputFieldText.text == "EISUN" || InputFieldText.text == "EISUNF" || InputFieldText.text == "EISUNFA" || InputFieldText.text == "EISUNFAL" || InputFieldText.text == "EISUNFALL" || InputFieldText.text == "EISUNFALL " || InputFieldText.text == "EISUNFALL 2")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            Eisunfall2.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "E"|| InputFieldText.text == "EI"||InputFieldText.text == "EIN"||InputFieldText.text == "EINS"||InputFieldText.text == "EINST" || InputFieldText.text == "EINSTU" || InputFieldText.text == "EINSTUR" || InputFieldText.text == "EINSTURZ")
        {
            int size = 32 * 1;

           contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            Einsturz.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "I"|| InputFieldText.text == "In" || InputFieldText.text == "Int" || InputFieldText.text == "Inte" || InputFieldText.text == "Inten" || InputFieldText.text == "Intens" || InputFieldText.text == "Intesi" || InputFieldText.text == "Intesiv" || InputFieldText.text == "Intesiv1" || InputFieldText.text == "Intesiv 1")
        {
            int size = 32 * 1;

           contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
           Inten1.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "I" || InputFieldText.text == "In" || InputFieldText.text == "Int" || InputFieldText.text == "Inte" || InputFieldText.text == "Inten" || InputFieldText.text == "Intens" || InputFieldText.text == "Intesi" || InputFieldText.text == "Intesiv" || InputFieldText.text == "Intesiv2" || InputFieldText.text == "Intesiv 2")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            Inten2.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "I" || InputFieldText.text == "In" || InputFieldText.text == "Int" || InputFieldText.text == "Inte" || InputFieldText.text == "Inten" || InputFieldText.text == "Intens" || InputFieldText.text == "Intesi" || InputFieldText.text == "Intesiv" || InputFieldText.text == "Intesiv3" || InputFieldText.text == "Intesiv 3")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            Inten3.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "I" || InputFieldText.text == "In" || InputFieldText.text == "Int" || InputFieldText.text == "Inte" || InputFieldText.text == "Inten" || InputFieldText.text == "Intens" || InputFieldText.text == "Intesi" || InputFieldText.text == "Intesiv" || InputFieldText.text == "Intesiv4" || InputFieldText.text == "Intesiv 4")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            Inten4.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "K")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            Krankentransport.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "M"|| InputFieldText.text == "MA"||InputFieldText.text == "MAN" || InputFieldText.text == "MANV" || InputFieldText.text == "MANV1" || InputFieldText.text == "MANV 1")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            MANV1.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "M" || InputFieldText.text == "MA" || InputFieldText.text == "MAN" || InputFieldText.text == "MANV" || InputFieldText.text == "MANV2" || InputFieldText.text == "MANV 2")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            MANV2.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "N")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            Notfallseelsorge.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "P"|| InputFieldText.text == "P " || InputFieldText.text == "P S" || InputFieldText.text == "P St" || InputFieldText.text == "P Str" || InputFieldText.text == "P Stro" || InputFieldText.text == "P Strom")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            PStrom.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "P")
        {
            int size = 32 * 6;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            Peingeklemmt.gameObject.SetActive(true);
            PAufzug.gameObject.SetActive(true);
            PRettungHöhenuTiefen.gameObject.SetActive(true);
            PsychosozialeUnterstürzung.gameObject.SetActive(true);
            Pverschüttet.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "R" || InputFieldText.text == "RD" || InputFieldText.text == "RD1"|| InputFieldText.text == "RD 1")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            RD1.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "R" || InputFieldText.text == "RD" || InputFieldText.text == "RD2" || InputFieldText.text == "RD 2")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            RD2.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "R" || InputFieldText.text == "RD" || InputFieldText.text == "RD3" || InputFieldText.text == "RD 3")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            RD3.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "R" || InputFieldText.text == "RD" || InputFieldText.text == "RD4" || InputFieldText.text == "RD 4")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            RD4.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "R" || InputFieldText.text == "RD" || InputFieldText.text == "RD5" || InputFieldText.text == "RD 5")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            RD5.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "R" || InputFieldText.text == "RD" || InputFieldText.text == "RD2" || InputFieldText.text == "RD 2" || InputFieldText.text == "RD2 K" || InputFieldText.text == "RD 2 K" || InputFieldText.text == "RD2 Ki" || InputFieldText.text == "RD 2 Ki" || InputFieldText.text == "RD2 Kin" || InputFieldText.text == "RD 2 Kin" || InputFieldText.text == "RD2 Kind" || InputFieldText.text == "RD 2 Kind")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            RD5.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "R"|| InputFieldText.text == "RD" || InputFieldText.text == "RD1" || InputFieldText.text == "RD 1" || InputFieldText.text == "RD1 N" || InputFieldText.text == "RD 1 N" || InputFieldText.text == "RD1 Ne" || InputFieldText.text == "RD 1 Ne" || InputFieldText.text == "RD1 Neu" || InputFieldText.text == "RD 1 Neu" || InputFieldText.text == "RD1 Neug" || InputFieldText.text == "RD 1 Neug" || InputFieldText.text == "RD1 Neuge" || InputFieldText.text == "RD 1 Neuge" || InputFieldText.text == "RD1 Neugeb" || InputFieldText.text == "RD 1 Neugeb" || InputFieldText.text == "RD1 Neugebo" || InputFieldText.text == "RD 1 Neugebo" || InputFieldText.text == "RD1 Neugebor" || InputFieldText.text == "RD 1 Neugebor" || InputFieldText.text == "RD1 Neugebore" || InputFieldText.text == "RD 1 Neugebore" || InputFieldText.text == "RD1 Neugeboren" || InputFieldText.text == "RD 1 Neugeboren" || InputFieldText.text == "RD1 Neugeborend" || InputFieldText.text == "RD 1 Neugeborend" || InputFieldText.text == "RD1 Neugeborende" || InputFieldText.text == "RD 1 Neugeborende" || InputFieldText.text == "RD1 Neugeborendes" || InputFieldText.text == "RD 1 Neugeborendes")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            RD1Neugeborendes.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "T" || InputFieldText.text == "TH" || InputFieldText.text == "THL" || InputFieldText.text == "THL1" || InputFieldText.text == "THL 1")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            THL1.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "T" || InputFieldText.text == "TH" || InputFieldText.text == "THL" || InputFieldText.text == "THL2" || InputFieldText.text == "THL 2")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            THL2.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "T" || InputFieldText.text == "TH" || InputFieldText.text == "THL" || InputFieldText.text == "THL3" || InputFieldText.text == "THL 3")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            THL3.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "T" || InputFieldText.text == "TH" || InputFieldText.text == "THL" || InputFieldText.text == "THL4" || InputFieldText.text == "THL 4")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            THL4.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "T" || InputFieldText.text == "TH" || InputFieldText.text == "THL" || InputFieldText.text == "THL5" || InputFieldText.text == "THL 5")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            THL5.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "T" || InputFieldText.text == "TH" || InputFieldText.text == "THL" || InputFieldText.text == "THL A" || InputFieldText.text == "THL AB" || InputFieldText.text == "THL ABC")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            THLABC.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "T" || InputFieldText.text == "Ta" || InputFieldText.text == "Tau" || InputFieldText.text == "Tauc" || InputFieldText.text == "Tauch" || InputFieldText.text == "Tauchu" || InputFieldText.text == "Tauchun" || InputFieldText.text == "Tauchunf" || InputFieldText.text == "Tauchunfa" || InputFieldText.text == "Tauchunfal" || InputFieldText.text == "Tauchunfall")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            Tauchunfall.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "T" || InputFieldText.text == "TR" || InputFieldText.text == "TRA" || InputFieldText.text == "TRAG" || InputFieldText.text == "TRAGE" || InputFieldText.text == "TRAGEH" || InputFieldText.text == "TRAGEHI" || InputFieldText.text == "TRAGEHIL" || InputFieldText.text == "TRAGEHILF" || InputFieldText.text == "TRAGEHILFE")
        {
            int size = 32 * 2;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            Tragehilfe.gameObject.SetActive(true);
            
        }
        if (InputFieldText.text == "V" || InputFieldText.text == "VU" || InputFieldText.text == "VU " || InputFieldText.text == "VU F" || InputFieldText.text == "VU Fl" || InputFieldText.text == "VU Flu" || InputFieldText.text == "VU Flug" || InputFieldText.text == "VU Flugz" || InputFieldText.text == "VU Flugze" || InputFieldText.text == "VU Flugzeu" || InputFieldText.text == "VU Flugzeug" || InputFieldText.text == "VU Flugzeug " || InputFieldText.text == "VU Flugzeug2" || InputFieldText.text == "VU Flugzeug 2")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            VUFluzeug2.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "V" || InputFieldText.text == "VU" || InputFieldText.text == "VU " || InputFieldText.text == "VU Z" || InputFieldText.text == "VU Zu" || InputFieldText.text == "VU Zug")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            VUZug.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "W"|| InputFieldText.text == "Wa" || InputFieldText.text == "Was" || InputFieldText.text == "Wass" || InputFieldText.text == "Wasse" || InputFieldText.text == "Wasser" || InputFieldText.text == "Wassern" || InputFieldText.text == "Wasserno" || InputFieldText.text == "Wassernot" || InputFieldText.text == "Wassernot1" || InputFieldText.text == "Wassernot 1")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            Wassernot1.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "W" || InputFieldText.text == "Wa" || InputFieldText.text == "Was" || InputFieldText.text == "Wass" || InputFieldText.text == "Wasse" || InputFieldText.text == "Wasser" || InputFieldText.text == "Wassern" || InputFieldText.text == "Wasserno" || InputFieldText.text == "Wassernot" || InputFieldText.text == "Wassernot2" || InputFieldText.text == "Wassernot 2")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            Wassernot2.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "W" || InputFieldText.text == "Wa" || InputFieldText.text == "Was" || InputFieldText.text == "Wass" || InputFieldText.text == "Wasse" || InputFieldText.text == "Wasser" || InputFieldText.text == "Wassern" || InputFieldText.text == "Wasserno" || InputFieldText.text == "Wassernot" || InputFieldText.text == "Wassernot3" || InputFieldText.text == "Wassernot 3")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            Wassernot3.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "Ö"|| InputFieldText.text == "ÖL"||InputFieldText.text == "ÖLS" || InputFieldText.text == "ÖLSP" || InputFieldText.text == "ÖLSPU" || InputFieldText.text == "ÖLSPUR")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            Ölspur.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "Ü"|| InputFieldText.text == "Üb" || InputFieldText.text == "Übe" || InputFieldText.text == "Über" || InputFieldText.text == "Überö" || InputFieldText.text == "Überör" || InputFieldText.text == "Überört" || InputFieldText.text == "Überörtl" || InputFieldText.text == "Überörtli" || InputFieldText.text == "Überörtlic" || InputFieldText.text == "Überörtlich" || InputFieldText.text == "Überörtliche" || InputFieldText.text == "Überörtlier" || InputFieldText.text == "Überörtlier E" || InputFieldText.text == "Überörtlier Ei" || InputFieldText.text == "Überörtlier Ein" || InputFieldText.text == "Überörtlier Eins" || InputFieldText.text == "Überörtlier Einsa" || InputFieldText.text == "Überörtlier Einsat" || InputFieldText.text == "Überörtlier Einsatz")
        {
            int size = 32 * 1;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            ÜberörtlicherEinsatz.gameObject.SetActive(true);
        }
        if (InputFieldText.text == "")
        {
            int size = 32 * 60;

            contentRectTransform.sizeDelta = new Vector2(contentRectTransform.sizeDelta.x, contentRectTransform.sizeDelta.y + size);
            AbischerungsButton.gameObject.SetActive(true);
            AbischerungsButton.gameObject.SetActive(false);

            B1.gameObject.SetActive(true);
            B1P.gameObject.SetActive(true);
            B2.gameObject.SetActive(true);
            B2P.gameObject.SetActive(true);
            B3.gameObject.SetActive(true);
            B3P.gameObject.SetActive(true);
            B4.gameObject.SetActive(true);
            B5.gameObject.SetActive(true);
            B6.gameObject.SetActive(true);
            B7.gameObject.SetActive(true);
            BBMA.gameObject.SetActive(true);
            BABC.gameObject.SetActive(true);
            BBeleuchtug.gameObject.SetActive(true);
            BenzinausPKW.gameObject.SetActive(true);
            Bombenfund.gameObject.SetActive(true);
            BBoot.gameObject.SetActive(true);
            BELEKTROANLANGE.gameObject.SetActive(true);
            BSchienen.gameObject.SetActive(true);
            Bexplosion.gameObject.SetActive(true);
            BWald.gameObject.SetActive(true);
            BZug.gameObject.SetActive(true);

            Eisunfall1.gameObject.SetActive(true);
            Eisunfall2.gameObject.SetActive(true);

            Einsturz.gameObject.SetActive(true);

            Inten1.gameObject.SetActive(true);
            Inten2.gameObject.SetActive(true);
            Inten3.gameObject.SetActive(true);
            Inten4.gameObject.SetActive(true);

            Krankentransport.gameObject.SetActive(true);

            MANV1.gameObject.SetActive(true);
            MANV2.gameObject.SetActive(true);

            Notfallseelsorge.gameObject.SetActive(true);

            Peingeklemmt.gameObject.SetActive(true);
            PAufzug.gameObject.SetActive(true);
            PRettungHöhenuTiefen.gameObject.SetActive(true);
            PStrom.gameObject.SetActive(true);
            PsychosozialeUnterstürzung.gameObject.SetActive(true);
            Pverschüttet.gameObject.SetActive(true);

            RD1.gameObject.SetActive(true);
            RD1Neugeborendes.gameObject.SetActive(true);
            RD2.gameObject.SetActive(true);
            RD2Kind.gameObject.SetActive(true);
            RD3.gameObject.SetActive(true);
            RD4.gameObject.SetActive(true);
            RD5.gameObject.SetActive(true);

            Tauchunfall.gameObject.SetActive(true);
            Tragehilfe.gameObject.SetActive(true);
            THL1.gameObject.SetActive(true);
            THL2.gameObject.SetActive(true);
            THL3.gameObject.SetActive(true);
            THL4.gameObject.SetActive(true);
            THL5.gameObject.SetActive(true);
            THLABC.gameObject.SetActive(true);

            Unwetter.gameObject.SetActive(true);
            VUFluzeug1.gameObject.SetActive(true);
            VUFluzeug2.gameObject.SetActive(true);
            VUZug.gameObject.SetActive(true);

            Wassernot1.gameObject.SetActive(true);
            Wassernot2.gameObject.SetActive(true);
            Wassernot3.gameObject.SetActive(true);

            Ölspur.gameObject.SetActive(true);
            ÜberörtlicherEinsatz.gameObject.SetActive(true);
        }
    }
    public void Change()
    {
        ResetButton();
        Einsatsliste.gameObject.SetActive(true);
    }
    public void End()
    {
        ResetButton();
        Einsatsliste.gameObject.SetActive(false);
    }
}
